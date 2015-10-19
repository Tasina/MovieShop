using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieShopDAL.BE
{
    public class Order
    {
        public int OrderId { get; set; }
        [DataType(DataType.Date)]
        [Required]
        public DateTime Date { get; set; }
        [Required(ErrorMessage = "Customer is required")]
        public int CustomerId { get; set; }
        [Required(ErrorMessage = "Movie is required")]
        public int MovieId { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Movie Movie { get; set; }
    }
}
