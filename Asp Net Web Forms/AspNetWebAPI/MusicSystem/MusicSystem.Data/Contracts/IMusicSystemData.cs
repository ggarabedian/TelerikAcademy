namespace MusicSystem.Data.Contracts
{
    using Models;

    public interface IMusicSystemData
    {
        IGenericRepository<Album> Albums { get; }

        IGenericRepository<Artist> Artists { get; }

        IGenericRepository<Country> Countries { get; }

        IGenericRepository<Genre> Genres { get; }

        IGenericRepository<Song> Songs { get; }

        int Savechanges();
    }
}
