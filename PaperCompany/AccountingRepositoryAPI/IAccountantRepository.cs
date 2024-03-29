﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaperCompany.Entities.AccountingApi;

namespace PaperCompany.Repository.AccountingRepositoryApi
{
    public interface IAccountantRepository
    {
        void Add(IAccountant accountant);
        void Delete(string accountantId);
        IAccountant GetById(string accountantId);
        List<IAccountant> GetAll();
    }
}
