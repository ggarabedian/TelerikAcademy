namespace CookiesWithTwoPages
{
    using System;
    using System.Web;

    public partial class FirstPage : System.Web.UI.Page
    {       
        protected void Page_PreRender(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.LabelMessage.Text = "";
            }

            if (Session["message"] != null)
            {
                this.LabelMessage.Text = Session["message"].ToString();
            }

            if (Session.IsNewSession)
            {
                if (Application["counter"] == null)
                {
                    Application["counter"] = 0;
                }

                Application["counter"] = (int)Application["counter"] + 1;
            }

            this.LabelCounter.Text = Application["counter"].ToString();
        }

        protected void ButtonLogIn_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("LoggedUser");
            cookie.Expires = DateTime.UtcNow.AddMinutes(1);

            this.Response.Cookies.Add(cookie);

            Session["message"] = "You are now logged in. You may proceed to the second page!!";
        }

        protected void ButtonSecondPage_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = this.Request.Cookies["LoggedUser"];

            if (cookie == null)
            {
                Session["message"] = "You must be logged to see the second page!!";
                this.Response.Redirect("FirstPage.aspx");
            }
            else
            {
                this.Response.Redirect("SecondPage.aspx");
            }
        }
    }
}