namespace MusicSystem.Web.Controllers
{
    using System.Linq;
    using System.Web.Http;

    using Data;
    using Data.Contracts;
    using MusicSystem.Models;
    using MusicSystem.Web.Models;

    public class AlbumsController : ApiController
    {
        private readonly IGenericRepository<Album> data;

        public AlbumsController()
        {
            var db = new MusicSystemDbContext();
            this.data = new EfGenericRepository<Album>(db);
        }

        public IHttpActionResult Get()
        {
            var result = this.data
                .All()
                .OrderBy(alb => alb.Title)
                .Select(alb => new AlbumDataModel
                {
                    Title = alb.Title,
                    Year = alb.Year,
                    Producer = alb.Producer
                })
                .ToList();

            return this.Ok(result);
        }

        public IHttpActionResult Get(int id)
        {
            var album = this.data.GetById(id);

            if (album == null)
            {
                return this.BadRequest("Album not found.");
            }

            return this.Ok(album);
        }

        public IHttpActionResult Post(AlbumDataModel model)
        {
            var newAlbum = new Album
            {
                Title = model.Title,
                Year = model.Year,
                Producer = model.Producer
            };

            this.data.Add(newAlbum);
            this.data.SaveChanges();

            return this.Ok("Album " + newAlbum.Title + " was created.");
        }

        public IHttpActionResult Put(int id, AlbumDataModel model)
        {
            var album = this.data.GetById(id);

            if (album == null)
            {
                return this.BadRequest("Album not found.");
            }

            album.Title = model.Title;
            album.Year = model.Year;
            album.Producer = model.Producer;

            this.data.Update(album);
            this.data.SaveChanges();

            return this.Ok("Album with id " + id + " was modified.");
        }

        public IHttpActionResult Delete(int id)
        {
            this.data.Delete(id);
            this.data.SaveChanges();
            return this.Ok("Album with id " + id + " was removed.");
        }
    }
}