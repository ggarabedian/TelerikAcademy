namespace FileUpload
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;

    using Ionic.Zip;

    /* Знам, че по условие информацията трябваше да се запазва в база данни, но не видях смисъл да правя цяла база 
    за 3 текстови полета. Спазил съм условията и вместо да запазвам стринговете в база данни ги принтирам на страницата */

    public partial class FileUpload : System.Web.UI.Page
    {
        private static List<string> fileContents = new List<string>();

        protected void Page_PreRender(object sender, EventArgs e)
        {
            this.RepeaterZipContent.DataSource = fileContents;
            this.RepeaterZipContent.DataBind();
        }

        protected void UploadButton_Click(object sender, EventArgs e)
        {
            if (FileUploadSelect.HasFile)
            {
                string extension = Path.GetExtension(FileUploadSelect.FileName);

                if (extension != ".zip")
                {
                    this.LiteralMessage.Text = "You must upload a .zip file!";
                    return;
                }
            }
            else
            {
                this.LiteralMessage.Text = "You must select a file to be uploaded!";
                return;
            }

            var file = FileUploadSelect.PostedFile.InputStream;

            using (MemoryStream ms = new MemoryStream())
            {
                using (ZipFile zip = ZipFile.Read(file))
                {
                    foreach (ZipEntry entry in zip)
                    {
                        entry.Extract(ms);

                        var content = Encoding.ASCII.GetString(ms.ToArray());
                        fileContents.Add(content);

                        ms.SetLength(0);
                    }
                }
            }
        }
    }
}