using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieShopDAL.DB
{
    public static class DBInitializer
    {
        public static void Initialize()
        {
            Database.SetInitializer(new MovieShopDBInitializer());
        }
    }
}
