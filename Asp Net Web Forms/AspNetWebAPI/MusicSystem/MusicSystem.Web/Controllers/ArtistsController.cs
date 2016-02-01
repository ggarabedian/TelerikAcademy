namespace MusicSystem.Web.Controllers
{
    using System.Linq;
    using System.Web.Http;

    using Data;
    using Data.Contracts;
    using MusicSystem.Models;
    using MusicSystem.Web.Models;

    public class ArtistsController : ApiController
    {
        private readonly IGenericRepository<Artist> data;

        public ArtistsController()
        {
            var db = new MusicSystemDbContext();
            this.data = new EfGenericRepository<Artist>(db);
        }

        public IHttpActionResult Get()
        {
            var result = this.data
                .All()
                .OrderBy(art => art.Name)
                .Select(art => new ArtistDataModel
                {
                    Name = art.Name,
                    DateOfBirth = art.DateOfBirth,
                    CountryId = art.CountryId
                })
                .ToList();

            return this.Ok(result);
        }

        public IHttpActionResult Get(int id)
        {
            var artist = this.data.GetById(id);

            if (artist == null)
            {
                return this.BadRequest("Artist not found.");
            }

            return this.Ok(artist);
        }

        public IHttpActionResult Post(ArtistDataModel model)
        {
            var newArtist = new Artist
            {
                Name = model.Name,
                DateOfBirth = model.DateOfBirth,
                CountryId = model.CountryId
            };

            this.data.Add(newArtist);
            this.data.SaveChanges();

            return this.Ok("Artist " + newArtist.Name + " was created.");
        }

        public IHttpActionResult Put(int id, ArtistDataModel model)
        {
            var artist = this.data.GetById(id);

            if (artist == null)
            {
                return this.BadRequest("Artist not found.");
            }

            artist.Name = model.Name;
            artist.DateOfBirth = model.DateOfBirth;
            artist.CountryId = model.CountryId;

            this.data.Update(artist);
            this.data.SaveChanges();

            return this.Ok("Song with id " + id + " was modified.");
        }

        public IHttpActionResult Delete(int id)
        {
            this.data.Delete(id);
            this.data.SaveChanges();
            return this.Ok("Artist with id " + id + " was removed.");
        }
    }
}