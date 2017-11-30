using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Entities.Accounting.Api;

namespace Company.Repository.Api
{
    public interface IAccountantRepository
    {
        void Add(IAccountant payment);
        void Delete(string accountantId);
        IAccountant GetById(string accountantId);
        List<IAccountant> GetAll();
    }
}
