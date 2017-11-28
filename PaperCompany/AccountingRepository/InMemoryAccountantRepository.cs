using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Entity.AccountingAPI;
using Company.Facade.AccountingRepositoryAPI;

namespace Company.Repository.AccountingRepository
{
    class InMemoryAccountantRepository
    {
        private List<IAccountant> _accountants = new List<IAccountant>();

        public void Add(IAccountant payment)
        {
            if (!_accountants.Any(x => x.AccountantId == payment.AccountantId))
            {
                _accountants.Add(payment);
            }
            else
            {
                throw new Exception("This payment record already exists.");
            }
        }

        public void Delete(int accountantId)
        {
            _accountants.RemoveAll(x => x.AccountantId == accountantId);
        }

        public List<IAccountant> GetAll()
        {
            return _accountants;
        }

        public IAccountant GetById(int accountantId)
        {
            return _accountants.FirstOrDefault(x => x.AccountantId == accountantId);
        }
    }
}
