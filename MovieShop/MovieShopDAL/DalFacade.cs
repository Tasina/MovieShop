﻿using MovieStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieShopDAL
{
    public class DALFacade
    {
        System.Data.Entity.SqlServer.SqlProviderServices
            ensureDLLIsCopied = System.Data.Entity.SqlServer.SqlProviderServices.Instance;

        private IRepository<Customer> customerRepo;
        private IRepository<Genre> genreRepo;
        private IRepository<Movie> movieRepo;

    }
}