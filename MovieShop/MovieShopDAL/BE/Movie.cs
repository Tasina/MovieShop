using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieStore.Models
{
    public class Movie
    {
        [ScaffoldColumn(false)]
        public int MovieId { get; set; }
        [Required(ErrorMessage = "A Title is required!")]
        public string Title { get; set; }
        [Required]
        public DateTime Year { get; set; }
        [Required(ErrorMessage = "Price is required")]
        [Range(1, 100,
            ErrorMessage = "Price must be between 1 and 100")]
        public int Price { get; set; }
        public string ImageUrl { get; set; }
        public string TrailerUrl { get; set; }
        public virtual Genre Genre { get; set; }
        
    }
}