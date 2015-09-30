using MovieShopDAL.Repositories.Impl;
using MovieStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieShopDAL
{
    public class DALFacade
    {
        // test
        System.Data.Entity.SqlServer.SqlProviderServices
            ensureDLLIsCopied = System.Data.Entity.SqlServer.SqlProviderServices.Instance;

        private IRepository<Customer> customerRepo;
        private IRepository<Genre> genreRepo;
        private IRepository<Movie> movieRepo;

        public IRepository<Customer> CustomerRepository
        {
            get
            {
                return customerRepo == null ? customerRepo = new CustomerRepository() : customerRepo;
            }
        }

        public IRepository<Genre> GenreRepository
        {
            get
            {
                return genreRepo == null ? genreRepo = new GenreRepository() : genreRepo;
            }
        }

        public IRepository<Movie> MovieRepository
        {
            get
            {
                return movieRepo != null ? movieRepo : movieRepo = new MovieRepository();
            }
        }

    }
}
