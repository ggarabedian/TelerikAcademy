namespace Countries.Migrations
{
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    using System.Linq;

    using Data;

    internal sealed class Configuration : DbMigrationsConfiguration<Countries.Data.EarthDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(EarthDbContext context)
        {
            if (context.Continents.Any())
            {
                return;
            }

            IList<Continent> continents = new List<Continent>()
            {
                new Continent() { Name = "Europe" },
                new Continent() { Name = "Asia" },
                new Continent() { Name = "Africa" },
                new Continent() { Name = "North America" },
                new Continent() { Name = "South America" },
            };

            IList<Country> countries = new List<Country>()
            {
                new Country() { Name = "Bulgaria", Population = 7000000, Language = "Bulgarian", Continent = continents[0] },
                new Country() { Name = "France", Population = 58000000, Language = "French", Continent = continents[0]  },
                new Country() { Name = "China", Population = 2000000000, Language = "Chinese", Continent = continents[1]  },
            };

            IList<Town> towns = new List<Town>()
            {
                new Town() { Name = "Sofia", Population = 2000000, Country = countries[0] },
                new Town() { Name = "Plovdiv", Population = 1000000, Country = countries[0] },
                new Town() { Name = "Paris", Population = 17000000, Country = countries[1] },
            };

            context.Continents.AddOrUpdate(continents.ToArray());
            context.Countries.AddOrUpdate(countries.ToArray());
            context.Towns.AddOrUpdate(towns.ToArray());
        }
    }
}
