namespace MusicSystem.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Songs")]
    public class Song
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(100)]
        public string Title { get; set; }

        public int? Year { get; set; }

        public int GenreId { get; set; }

        [ForeignKey("GenreId")]
        public virtual Genre Genre { get; set; }

        public int ArtistId { get; set; }

        [ForeignKey("ArtistId")]
        public virtual Artist Artist { get; set; }
    }
}
