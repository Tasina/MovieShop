using MovieShopDAL.BE;
using MovieShopDAL.DB;
using System;
using System.Collections.Generic;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieShopDAL.Repositories
{
    class MovieRepository : IRepository<Movie>
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
            return db.Movies.FirstOrDefault(m => m.MovieId == id);
        }

        public IEnumerable<Movie> GetAll()
        {
            return db.Movies.ToList();
        }

        public void Remove(int id)
        {
            db.Movies.Remove(Get(id));
            db.SaveChanges();
        }
    }
}
