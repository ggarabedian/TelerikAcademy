namespace Countries.Data
{
    using Migrations;
    using System.Data.Entity;

    public class EarthDbContext : DbContext
    {
        public EarthDbContext() : base("EarthDbContext")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<EarthDbContext, Configuration>());
        }

        public DbSet<Continent> Continents { get; set; }

        public DbSet<Country> Countries { get; set; }

        public DbSet<Town> Towns { get; set; }

    }
}