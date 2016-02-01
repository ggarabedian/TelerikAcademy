namespace MusicSystem.Web
{
    using System.Data.Entity;
    using System.Web;
    using System.Web.Http;

    using Data;
    using Data.Migrations;

    public class WebApiApplication : HttpApplication
    {
        protected void Application_Start()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MusicSystemDbContext, Configuration>());

            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
