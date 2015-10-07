using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieShopDAL.BE
{
    public class Genre
    {
        public int GenreId { get; set; }
        [Required(ErrorMessage = "A Genre Title is required!")]
        [Display(Name = "Genre")]
        public string Name { get; set; }
        public virtual List<Movie> Movies { get; set; }
    }
}
