using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieStore.Models
{
    public class Genre
    {
        //[Display(Name="Genre")]
        //[StringLength(20,ErrorMessage = "Maks 20 tegn")]
        public int GenreId { get; set; }
        [Required(ErrorMessage ="A Genre Title is required!")]
        public string Name { get; set; }
        public virtual List<Movie> Movies { get; set; }
    }
}