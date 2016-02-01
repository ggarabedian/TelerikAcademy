namespace StudentSystem.Api
{
    using System.Data.Entity;
    using System.Web.Http;

    using Data;
    using Data.Migrations;
    using Newtonsoft.Json;

    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            JsonConvert.DefaultSettings = () => new JsonSerializerSettings
            {
                Formatting = Newtonsoft.Json.Formatting.Indented,
                ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
            };

            Database.SetInitializer(new MigrateDatabaseToLatestVersion<StudentSystemDbContext, Configuration>());

            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
