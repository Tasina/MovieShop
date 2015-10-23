using MovieShopDAL.BE;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace MovieShopDAL.DB
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
                new Movie { Title = "Mission impossible", Genre = myGenre2, Year = DateTime.Now, Price = 60, ImageUrl = "/content/images/missionimp.jpg", TrailerUrl = "https://www.youtube.com/embed/pXwaKB7YOjw" },
                new Movie { Title = "Die Hard", Genre = myGenre2, Year = DateTime.Now, Price = 15, ImageUrl = "/content/images/diehard1.jpg", TrailerUrl = "https://www.youtube.com/embed/2TQ-pOvI6Xo" },
                new Movie { Title = "Die Hard 2", Genre = myGenre2, Year = DateTime.Now, Price = 30, ImageUrl = "/content/images/diehard2.jpg", TrailerUrl = "https://www.youtube.com/embed/xd3ZAuNeJqg" },
                new Movie { Title = "Lego the movie", Genre = myGenre3, Year = DateTime.Now, Price = 43, ImageUrl = "/content/images/legomovie.jpg", TrailerUrl = "https://www.youtube.com/embed/lPnY2NjSjrg" },
                new Movie { Title = "The grudge", Genre = myGenre4, Year = DateTime.Now, Price = 59, ImageUrl = "/content/images/thegrudge.jpg", TrailerUrl = "https://www.youtube.com/embed/OdRKXXigZWY" },
                new Movie { Title = "Toy Story", Genre = myGenre2, Year = DateTime.Now, Price = 75, ImageUrl = "/content/images/toystory.jpg", TrailerUrl = "https://www.youtube.com/embed/KYz2wyBy3kc" },
                new Movie { Title = "Movie one of the one", Genre = myGenre1, Year = DateTime.Now, Price = 60, ImageUrl = "", TrailerUrl = "" },
                new Movie { Title = "Die Hard", Genre = myGenre2, Year = DateTime.Now, Price = 70, ImageUrl = "", TrailerUrl = "" },
                new Movie { Title = "Hunger Games", Genre = myGenre2, Year = DateTime.Now, Price = 99, ImageUrl = "/content/images/hungergames.jpg", TrailerUrl = "https://www.youtube.com/embed/4S9a5V9ODuY" },
                new Movie { Title = "Men Of Honor", Genre = myGenre2, Year = DateTime.Now, Price = 74, ImageUrl = "/content/images/menofhonor.jpg", TrailerUrl = "https://www.youtube.com/embed/9HxndukCV38" },
                new Movie { Title = "Die Hard 3", Genre = myGenre2, Year = DateTime.Now, Price = 80, ImageUrl = "", TrailerUrl = "" },
                new Movie { Title = "Hunger Games 2", Genre = myGenre2, Year = DateTime.Now, Price = 99, ImageUrl = "/content/images/hungergames2.jpg", TrailerUrl = "https://www.youtube.com/embed/MkvUNfySGQU" }
            };

            context.Genres.Add(myGenre3);
            context.Movies.AddRange(movies);


            base.Seed(context);
        }
    }
}
