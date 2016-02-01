namespace MusicSystem.Web.Controllers
{
    using System.Linq;
    using System.Web.Http;

    using Data;
    using Data.Contracts;
    using MusicSystem.Models;
    using MusicSystem.Web.Models;

    public class SongsController : ApiController
    {
        private readonly IGenericRepository<Song> data;

        public SongsController()
        {
            var db = new MusicSystemDbContext();
            this.data = new EfGenericRepository<Song>(db);
        }

        public IHttpActionResult Get()
        {
            var result = this.data
                .All()
                .OrderBy(s => s.Title)
                .Select(s => new SongDataModel
                {
                    Title = s.Title,
                    Year = s.Year,
                    GenreId = s.GenreId,
                    ArtistId = s.ArtistId
                })
                .ToList();

            return this.Ok(result);
        }

        public IHttpActionResult Get(int id)
        {
            var song = this.data.GetById(id);

            if (song == null)
            {
                return this.BadRequest("Song not found.");
            }

            return this.Ok(song);
        }

        public IHttpActionResult Post(SongDataModel model)
        {
            var newSong = new Song
            {
                Title = model.Title,
                Year = model.Year,
                GenreId = model.GenreId,
                ArtistId = model.ArtistId
            };

            this.data.Add(newSong);
            this.data.SaveChanges();

            return this.Ok("Song " + newSong.Title + " was created.");
        }

        public IHttpActionResult Put(int id, SongDataModel model)
        {
            var song = this.data.GetById(id);

            if (song == null)
            {
                return this.BadRequest("Song not found.");
            }

            song.Title = model.Title;
            song.Year = model.Year;
            song.GenreId = model.GenreId;
            song.ArtistId = model.ArtistId;

            this.data.Update(song);
            this.data.SaveChanges();

            return this.Ok("Song with id " + id + " was modified.");
        }

        public IHttpActionResult Delete(int id)
        {
            this.data.Delete(id);
            this.data.SaveChanges();
            return this.Ok("Song with id " + id + " was removed.");
        }
    }
}