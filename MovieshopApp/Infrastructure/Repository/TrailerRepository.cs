﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationCore.Contracts.Repositories;
using ApplicationCore.Entities;
using Infrastructure.Data;

namespace Infrastructure.Repository
{
    public class TrailerRepository : BaseRepository<Trailer>, ITrailerRepository
    {
        public TrailerRepository(MovieShopDbContext _con) : base(_con)
        {
        }
    }
}
