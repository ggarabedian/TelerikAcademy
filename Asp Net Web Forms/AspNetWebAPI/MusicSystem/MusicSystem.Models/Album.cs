namespace MusicSystem.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Albums")]
    public class Album
    {
        private ICollection<Song> songs;
        private ICollection<Artist> artists;

        public Album()
        {
            this.songs = new HashSet<Song>();
            this.artists = new HashSet<Artist>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(100)]
        public string Title { get; set; }

        public int? Year { get; set; }

        public string Producer { get; set; }

        public virtual ICollection<Song> Songs
        {
            get
            {
                return this.songs;
            }

            set
            {
                this.songs = value;
            }
        }

        public virtual ICollection<Artist> Artists
        {
            get
            {
                return this.artists;
            }

            set
            {
                this.artists = value;
            }
        }
    }
}
