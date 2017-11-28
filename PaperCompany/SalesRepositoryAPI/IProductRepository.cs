﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Entity.SalesAPI;

namespace Company.Facade.SalesRepositoryAPI
{
    public interface IProductRepository
    {
        void Add(IProduct product);
        void Delete(int productId);
        IProduct GetById(int productId);
        List<IProduct> GetAll();
    }
}