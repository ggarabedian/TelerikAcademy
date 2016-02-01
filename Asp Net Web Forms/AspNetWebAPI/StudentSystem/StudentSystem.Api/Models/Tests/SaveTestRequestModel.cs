namespace StudentSystem.Api.Models.Tests
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class SaveTestRequestModel
    {
        [Required]
        public Guid CourseId { get; set; }
    }
}