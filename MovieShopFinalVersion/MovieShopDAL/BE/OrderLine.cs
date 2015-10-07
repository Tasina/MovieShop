using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieShopDAL.BE
{
    public class OrderLine
    {
        private int amount { get; set; }

        public int Amount
        {
            get { return amount; }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Amount must be above 0");
                }
                amount = value;
            }
        }
        public Movie Movie { get; set; }
        //public Orderline()
        //{
        //}
    }
}
