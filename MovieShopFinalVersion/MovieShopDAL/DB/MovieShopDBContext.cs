using System.Data.Entity;

namespace MovieShopDAL.DB
{
    public class MovieShopDBContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx

        public MovieShopDBContext() : base("MovieShopDB")
        {
        }

        public System.Data.Entity.DbSet<MovieShopDAL.BE.Movie> Movies { get; set; }

        public System.Data.Entity.DbSet<MovieShopDAL.BE.Genre> Genres { get; set; }

        public System.Data.Entity.DbSet<MovieShopDAL.BE.Customer> Customers { get; set; }

        public System.Data.Entity.DbSet<MovieShopDAL.BE.Order> Orders { get; set; }
    }
}
