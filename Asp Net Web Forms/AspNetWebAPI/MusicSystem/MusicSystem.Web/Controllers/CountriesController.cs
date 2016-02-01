namespace MusicSystem.Web.Controllers
{
    using System.Linq;
    using System.Web.Http;

    using Data;
    using Data.Contracts;
    using MusicSystem.Models;
    using MusicSystem.Web.Models;

    public class CountriesController : ApiController
    {
        private readonly IGenericRepository<Country> data;

        public CountriesController()
        {
            var db = new MusicSystemDbContext();
            this.data = new EfGenericRepository<Country>(db);
        }

        public IHttpActionResult Get()
        {
            var result = this.data
                .All()
                .OrderBy(c => c.Name)
                .Select(c => new CountryDataModel
                {
                    Name = c.Name,
                })
                .ToList();

            return this.Ok(result);
        }

        public IHttpActionResult Get(int id)
        {
            var country = this.data.GetById(id);

            if (country == null)
            {
                return this.BadRequest("Country not found.");
            }

            return this.Ok(country);
        }

        public IHttpActionResult Post(CountryDataModel model)
        {
            var newCountry = new Country
            {
                Name = model.Name
            };

            this.data.Add(newCountry);
            this.data.SaveChanges();

            return this.Ok("Country " + newCountry.Name + " was created.");
        }

        public IHttpActionResult Put(int id, CountryDataModel model)
        {
            var country = this.data.GetById(id);

            if (country == null)
            {
                return this.BadRequest("Country not found.");
            }

            country.Name = model.Name;

            this.data.Update(country);
            this.data.SaveChanges();

            return this.Ok("Country with id " + id + " was modified.");
        }

        public IHttpActionResult Delete(int id)
        {
            this.data.Delete(id);
            this.data.SaveChanges();
            return this.Ok("Country with id " + id + " was removed.");
        }
    }
}