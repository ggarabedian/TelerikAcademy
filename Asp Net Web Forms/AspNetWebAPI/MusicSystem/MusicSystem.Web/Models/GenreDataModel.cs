namespace MusicSystem.Web.Models
{
    using System.ComponentModel.DataAnnotations;

    public class GenreDataModel
    {
        [Required]
        public string Name { get; set; }
    }
}