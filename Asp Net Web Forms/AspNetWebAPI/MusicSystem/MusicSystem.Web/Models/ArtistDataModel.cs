namespace MusicSystem.Web.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class ArtistDataModel
    {
        [Required]
        public string Name { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public int CountryId { get; set; }
    }
}