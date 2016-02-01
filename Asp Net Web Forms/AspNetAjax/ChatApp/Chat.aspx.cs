namespace ChatApp
{
    using System;
    using System.Collections.Generic;

    using Data;

    public partial class Chat : System.Web.UI.Page
    {
        private static List<Message> messages = new List<Message>
                                                {
                                                    new Message("Jim", "Hello everyone"),
                                                    new Message("John", "Hey there"),
                                                    new Message("Peter", "F yourself Jim"),
                                                    new Message("Jim", "Thank you Petey"),
                                                    new Message("Steven", "Hey guys. Whats up?"),
                                                    new Message("Mark", "Petey is spilling hate over Jim again...")
                                                };

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.ListViewMessages.DataSource = messages;
                this.DataBind();
            }
        }

        protected void ButtonSend_Click(object sender, EventArgs e)
        {
            var content = this.TextBoxMessage.Text;
            var username = this.TextBoxUsername.Text;

            var newMessage = new Message(username, content);

            messages.Add(newMessage);
        }

        protected void Timer_Tick(object sender, EventArgs e)
        {
            this.ListViewMessages.DataSource = messages;
            this.DataBind();
        }
    }
}