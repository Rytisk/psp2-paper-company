﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaperCompany.Entities.SalesApi;
using PaperCompany.Repository.SalesRepositoryApi;

namespace PaperCompany.Repository.SalesRepositoryInMemory
{
    public class InMemorySalesmanRepository : ISalesmanRepository
    {
        private List<ISalesman> _salesmans = new List<ISalesman>();

        public void Add(ISalesman salesman)
        {
            if (!_salesmans.Any(x => x.SalesmanId == salesman.SalesmanId))
            {
                _salesmans.Add(salesman);
            }
            else
            {
                throw new Exception("This salesman already exists.");
            }
        }

        public void Delete(string salesmanId)
        {
            _salesmans.RemoveAll(x => x.SalesmanId == salesmanId);
        }

        public List<ISalesman> GetAll()
        {
            return _salesmans;
        }

        public ISalesman GetById(string salesmanId)
        {
            return _salesmans.FirstOrDefault(x => x.SalesmanId == salesmanId);
        }
    }
}
