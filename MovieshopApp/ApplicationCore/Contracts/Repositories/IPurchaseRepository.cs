﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationCore.Entities;

namespace ApplicationCore.Contracts.Repositories
{
    public interface IPurchaseRepository:IRepository<Purchase>
    {
        IEnumerable<Purchase> GetAll(int pageSize = 30, int page = 1);
    }
}
