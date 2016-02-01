namespace StudentSystem.Api.Models.Homeworks
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class SaveHomeworkRequestModel
    {
        [Required]
        public string FileUrl { get; set; }

        public Guid CourseId { get; set; }

        public int StudentId { get; set; }

        public DateTime TimeSent { get; set; }
    }
}