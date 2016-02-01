namespace BrowserType
{
    using System;

    public partial class BrowserType : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.LiteralServerType.Text += "Browser: " + this.Request.Browser.Type + "<br/>";
            this.LiteralServerType.Text += "IP: " + this.Request.UserHostAddress;
        }
    }
}