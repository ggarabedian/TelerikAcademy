namespace MusicSystem.Web.Controllers
{
    using System.Linq;
    using System.Web.Http;

    using Data;
    using Data.Contracts;
    using MusicSystem.Models;
    using MusicSystem.Web.Models;

    public class GenresController : ApiController
    {
        private readonly IGenericRepository<Genre> data;

        public GenresController()
        {
            var db = new MusicSystemDbContext();
            this.data = new EfGenericRepository<Genre>(db);
        }

        public IHttpActionResult Get()
        {
            var result = this.data
                .All()
                .OrderBy(g => g.Name)
                .Select(g => new GenreDataModel
                {
                    Name = g.Name,
                })
                .ToList();

            return this.Ok(result);
        }

        public IHttpActionResult Get(int id)
        {
            var genre = this.data.GetById(id);

            if (genre == null)
            {
                return this.BadRequest("Genre not found.");
            }

            return this.Ok(genre);
        }

        public IHttpActionResult Post(GenreDataModel model)
        {
            var newGenre = new Genre
            {
                Name = model.Name
            };

            this.data.Add(newGenre);
            this.data.SaveChanges();

            return this.Ok("Genre " + newGenre.Name + " was created.");
        }

        public IHttpActionResult Put(int id, GenreDataModel model)
        {
            var genre = this.data.GetById(id);

            if (genre == null)
            {
                return this.BadRequest("Genre not found.");
            }

            genre.Name = model.Name;

            this.data.Update(genre);
            this.data.SaveChanges();

            return this.Ok("Genre with id " + id + " was modified.");
        }

        public IHttpActionResult Delete(int id)
        {
            this.data.Delete(id);
            this.data.SaveChanges();
            return this.Ok("Genre with id " + id + " was removed.");
        }
    }
}