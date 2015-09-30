using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieShopDAL
{
    class Customer
    {
        public int CustomerID { get; set; }
        [Required(ErrorMessage = "A FirstName is required!")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "A LastName is required!")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "A StreetName is required!")]
        public string StreetName { get; set; }
        [Required(ErrorMessage = "A HouseNumber is required!")]
        public string HouseNr { get; set; }
        [Required(ErrorMessage = "A ZipCode is required!")]
        public int ZipCode { get; set; }
        [Required(ErrorMessage = "A City is required!")]
        public string City { get; set; }
        [Required(ErrorMessage = "An Email is required!")]
        public string Email { get; set; }   
    }
}
