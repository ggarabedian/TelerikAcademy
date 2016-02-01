namespace StudentSystem.Api.Models.Students
{
    using System.ComponentModel.DataAnnotations;

    public class SaveStudentRequestModel
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public int Level { get; set; }
    }
}