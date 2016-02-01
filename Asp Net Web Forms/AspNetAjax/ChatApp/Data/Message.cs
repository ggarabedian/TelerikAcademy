namespace ChatApp.Data
{
    using System;

    public class Message
    {
        public Message()
        {

        }

        public Message(string username, string content)
        {
            this.Username = username;
            this.Content = content;
            this.CreatedOn = DateTime.UtcNow;
        }

        public string Username { get; set; }

        public string Content { get; set; }

        public DateTime CreatedOn { get; set; }
    }
}