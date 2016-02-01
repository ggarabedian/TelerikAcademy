namespace Session
{
    using System;

    public partial class SessionPage : System.Web.UI.Page
    {
        protected void Page_PreRender(object sender, EventArgs e)
        {
            if (Session["input"] != null)
            {
                this.LabelSessionType.Text = Session["input"].ToString();
            }
        }

        protected void ButtonSaveInput_Click(object sender, EventArgs e)
        {
            Session["input"] += this.TextBoxInput.Text + " ";
            this.TextBoxInput.Text = "";
        }
    }
}