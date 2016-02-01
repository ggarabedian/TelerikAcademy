namespace Countries.Data
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Country
    {
        public Country()
        {
            this.Towns = new HashSet<Town>();
        }

        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public long Population { get; set; }

        public string Language { get; set; }

        public byte[] Flag { get; set; }

        [ForeignKey("Continent")]
        public int ContinentId { get; set; }

        public virtual Continent Continent { get; set; }

        public virtual ICollection<Town> Towns { get; set; }
    }
}