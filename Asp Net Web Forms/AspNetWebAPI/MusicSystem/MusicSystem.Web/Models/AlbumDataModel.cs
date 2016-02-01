namespace MusicSystem.Web.Models
{
    using System.ComponentModel.DataAnnotations;

    public class AlbumDataModel
    {
        [Required]
        public string Title { get; set; }

        public int? Year { get; set; }

        public string Producer { get; set; }
    }
}