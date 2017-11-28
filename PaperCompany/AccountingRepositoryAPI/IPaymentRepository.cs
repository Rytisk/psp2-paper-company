using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Entity.AccountingAPI;

namespace Company.Facade.AccountingRepositoryAPI
{
    public interface IAccountantRepository
    {
        void Add(IAccountant payment);
        void Delete(int accountantId);
        IAccountant GetById(int accountantId);
        List<IAccountant> GetAll();
    }
}
