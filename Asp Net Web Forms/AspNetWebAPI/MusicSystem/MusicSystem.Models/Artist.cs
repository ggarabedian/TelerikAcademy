namespace MusicSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Artists")]
    public class Artist
    {
        private ICollection<Album> albums;

        public Artist()
        {
            this.albums = new HashSet<Album>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(2)]
        public string Name { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public int CountryId { get; set; }

        [ForeignKey("CountryId")]
        public virtual Country Country { get; set; }

        public virtual ICollection<Album> Albums
        {
            get
            {
                return this.albums;
            }

            set
            {
                this.albums = value;
            }
        }
    }
}
