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
    class GenreRepository : IRepository<Genre>
    {
        private MovieShopDBContext db = new MovieShopDBContext();

        SqlProviderServices ensureDLLIsCopied = SqlProviderServices.Instance;

        public void Add(Genre entity)
        {
            using (var db = new MovieShopDBContext())
            {
                db.Genres.Add(entity);
                db.SaveChanges();
            }
        }

        public void Edit(Genre entity)
        {
            using (var db = new MovieShopDBContext())
            {
                db.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public Genre Get(int id)
        {
            return db.Genres.FirstOrDefault(g => g.GenreId == id);
        }

        public IEnumerable<Genre> GetAll()
        {
            return db.Genres.ToList();
        }

        public void Remove(int id)
        {
            db.Genres.Remove(Get(id));
            db.SaveChanges();
        }
    }
}
