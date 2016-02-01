namespace Escaping
{
    using System;

    public partial class Escaping : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void PrintEscapedInput_Click(object sender, EventArgs e)
        {
            string input = this.TextBoxUserInput.Text;
            this.LabelEscapedInput.Text = Server.HtmlEncode(input);
            this.TextBoxEscapedInput.Text = Server.HtmlEncode(input);
        }
    }
}