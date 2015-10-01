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
            Genre myGenre4 = new Genre { Name = "Horror" };
            //Opret Movie

            List<Movie> movies = new List<Movie> {
                new Movie { Title = "Mission impossible", Genre = myGenre2, Year = DateTime.Now, Price = 60, ImageUrl = "/content/images/missionimp.jpg", TrailerUrl = "/src/trailer" },
                new Movie { Title = "Die Hard", Genre = myGenre2, Year = DateTime.Now, Price = 70, ImageUrl = "https://image.tmdb.org/t/p/w396/wICugQrQ60Uauu6KbA7fLIWirYY.jpg", TrailerUrl = "https://youtu.be/FRLwoMXaZHQ" },
                new Movie { Title = "Die Hard 2", Genre = myGenre2, Year = DateTime.Now, Price = 75, ImageUrl = "/content/images/diehard2.jpg", TrailerUrl = "/src/trailer" },
                 new Movie { Title = "Lego the movie", Genre = myGenre3, Year = DateTime.Now, Price = 60, ImageUrl = "/content/images/legomovie.jpg", TrailerUrl = "/src/trailer" },
                new Movie { Title = "The grudge", Genre = myGenre4, Year = DateTime.Now, Price = 70, ImageUrl = "/content/images/thegrudge.jpg", TrailerUrl = "/src/trailer" },
                new Movie { Title = "Toy Story", Genre = myGenre2, Year = DateTime.Now, Price = 75, ImageUrl = "/content/images/toystory.jpg", TrailerUrl = "/src/trailer" },
                 new Movie { Title = "Movie one of the one", Genre = myGenre1, Year = DateTime.Now, Price = 60, ImageUrl = "", TrailerUrl = "/src/trailer" },
                new Movie { Title = "Die Hard", Genre = myGenre2, Year = DateTime.Now, Price = 70, ImageUrl = "/content/images/diehard1.jpg", TrailerUrl = "https://youtu.be/FRLwoMXaZHQ" },
                new Movie { Title = "Die Hard 2", Genre = myGenre2, Year = DateTime.Now, Price = 75, ImageUrl = "/content/images/diehard2.jpg", TrailerUrl = "/src/trailer" }
        };
            context.Genres.Add(myGenre3);
            context.Movies.AddRange(movies);


            base.Seed(context);
        }
    }
}
