namespace StudentSystem.Api.Models.Homeworks
{
    using System;

    public class HomeworkResponseModel
    {
        public int Id { get; set; }

        public string FileUrl { get; set; }

        public DateTime TimeSent { get; set; }
    }
}