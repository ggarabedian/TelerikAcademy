namespace Countries.Data
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Town
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public long Population { get; set; }

        [ForeignKey("Country")]
        public int CountryId { get; set; }

        public virtual Country Country { get; set; }
    }
}