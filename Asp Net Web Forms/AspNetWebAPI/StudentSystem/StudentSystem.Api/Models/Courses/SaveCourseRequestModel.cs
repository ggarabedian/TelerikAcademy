namespace StudentSystem.Api.Models.Courses
{
    using System.ComponentModel.DataAnnotations;

    public class SaveCourseRequestModel
    {
        [Required]
        public string Name { get; set; }

        public string Description { get; set; }
    }
}