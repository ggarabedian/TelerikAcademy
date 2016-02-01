namespace MusicSystem.Web.Models
{
    using System.ComponentModel.DataAnnotations;

    public class SongDataModel
    {
        [Required]
        public string Title { get; set; }

        public int? Year { get; set; }

        public int GenreId { get; set; }

        public int ArtistId { get; set; }
    }
}