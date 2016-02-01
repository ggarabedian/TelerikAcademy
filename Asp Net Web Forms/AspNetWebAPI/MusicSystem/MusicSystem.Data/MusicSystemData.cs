namespace MusicSystem.Data
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;

    using Contracts;
    using Models;

    public class MusicSystemData : IMusicSystemData
    {
        private readonly DbContext context;
        private readonly IDictionary<Type, object> repositories;

        public MusicSystemData()
        {
            this.context = new MusicSystemDbContext();
            this.repositories = new Dictionary<Type, object>();
        }

        public IGenericRepository<Album> Albums
        {
            get
            {
                return this.GetRepository<Album>();
            }
        }

        public IGenericRepository<Artist> Artists
        {
            get
            {
                return this.GetRepository<Artist>();
            }
        }

        public IGenericRepository<Country> Countries
        {
            get
            {
                return this.GetRepository<Country>();
            }
        }

        public IGenericRepository<Genre> Genres
        {
            get
            {
                return this.GetRepository<Genre>();
            }
        }

        public IGenericRepository<Song> Songs
        {
            get
            {
                return this.GetRepository<Song>();
            }
        }

        public int Savechanges()
        {
            return this.context.SaveChanges();
        }

        private IGenericRepository<T> GetRepository<T>() where T : class
        {
            var typeOfRepository = typeof(T);

            if (!this.repositories.ContainsKey(typeOfRepository))
            {
                var newRepository = Activator.CreateInstance(typeof(EfGenericRepository<T>), this.context);
                this.repositories.Add(typeOfRepository, newRepository);
            }

            return (IGenericRepository<T>)this.repositories[typeOfRepository];
        }
    }
}
