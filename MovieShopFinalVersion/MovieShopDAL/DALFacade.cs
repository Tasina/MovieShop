using MovieShopDAL.BE;
using MovieShopDAL.DB;
using MovieShopDAL.Repositories;

namespace MovieShopDAL
{
    public class DALFacade
    {
        private IRepository<Movie> movieRepository;
        private IRepository<Genre> genreRepository;
        private IRepository<Customer> customerRepository;
        private IRepository<Order> orderRepository;

        public IRepository<Movie> MovieRepository
        {
            get
            {
                using (var db = new MovieShopDBContext())
                {
                    return movieRepository == null ? movieRepository =
                    new MovieRepository() : movieRepository;
                }
            }
        }

        public IRepository<Genre> GenreRepository
        {
            get
            {
                using (var db = new MovieShopDBContext())
                {
                    return genreRepository == null ? genreRepository =
                    new GenreRepository() : genreRepository;
                }
            }
        }

        public IRepository<Customer> CustomerRepository
        {
            get
            {
                using (var db = new MovieShopDBContext())
                {
                    return customerRepository == null ? customerRepository =
                    new CustomerRepository() : customerRepository;
                }
            }
        }

        public IRepository<Order> OrderRepository
        {
            get
            {
                using (var db = new MovieShopDBContext())
                {
                    return orderRepository == null ? orderRepository =
                    new OrderRepository() : orderRepository;
                }
            }
        }
    }
}
