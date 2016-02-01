namespace MusicSystem.Data.Migrations
{
    using System.Data.Entity.Migrations;

    public sealed class Configuration : DbMigrationsConfiguration<MusicSystemDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationDataLossAllowed = false;
            this.AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(MusicSystemDbContext context)
        {
        }
    }
}
