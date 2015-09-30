﻿using MovieStore.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.SqlServer;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieShopDAL.Repositories.Impl
{
    public class MovieRepository : IRepository<Movie>
    {
        private MovieShopDBContext db = new MovieShopDBContext();

        SqlProviderServices ensureDLLIsCopied = SqlProviderServices.Instance;

        public void Add(Movie entity)
        {
            using (var db = new MovieShopDBContext())
            {
                db.Movies.Add(entity);
                db.SaveChanges();
            }
        }

        //public void Dispose()
        //{
        //    db.Dispose();
        //}

        public void Edit(Movie entity)
        {
            using (var db = new MovieShopDBContext())
            {
                db.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public Movie Get(int id)
        {
            using (var db = new MovieShopDBContext())
            {
                //var movie = (from m in db.Movies
                //            where m.MovieId == id
                //            select m).FirstOrDefault();
                //return db.Movies.Include(g => g.Genre).FirstOrDefault(m => m.MovieId == id);
                return db.Movies.FirstOrDefault(m => m.MovieId == id);
            }
        }

        public IEnumerable<Movie> GetAll()
        {
            using (var db = new MovieShopDBContext())
            {
                //return db.Movies.Include(a => a.Genre).Include(g => g.Order).Tolist();

                //eager loading
                return db.Movies.Include(a => a.Genre).ToList();

                //leasy loading
                //return db.Movies.ToList();
            }
        }

        public void Remove(int id)
        {
            using (var db = new MovieShopDBContext())
            {
                //Ingen fejlhåndtering
                //var movie = this.Get(id);
                db.Movies.Remove(Get(id));
                db.SaveChanges();
            }
        }
    }
}
