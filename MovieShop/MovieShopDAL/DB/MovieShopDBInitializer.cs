using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using MovieStore.Models;

namespace MovieShopDAL
{
    public class MovieShopDBInitializer : DropCreateDatabaseAlways<MovieShopDBContext>
    {
        //Opret genre 
      


        protected override void Seed(MovieShopDBContext context)
        {

            Genre myGenre1 = new Genre { Name = "XXX" };
            Genre myGenre2 = new Genre { Name = "Action" };
            Genre myGenre3 = new Genre { Name = "Comedy" };
            //Opret Movie

            List<Movie> movies = new List<Movie> {
                new Movie { Title = "Movie one of the one", Genre = myGenre1, Year = DateTime.Now, Price = 60, ImageUrl = "/src/image", TrailerUrl = "/src/trailer" },
                new Movie { Title = "NewToTheMovies", Genre = myGenre3, Year = DateTime.Now, Price = 70, ImageUrl = "/src/image", TrailerUrl = "/src/trailer" }
        };
            context.Genres.Add(myGenre2);
            context.Movies.AddRange(movies);
            

            base.Seed(context);
        }
    }
}
