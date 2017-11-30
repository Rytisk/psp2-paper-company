using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Entities.Accounting.Api;
using Company.Repository.Api;

namespace Company.Repository.Accounting
{
    class InMemoryAccountantRepository : IAccountantRepository
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
                throw new Exception("This accountant record already exists.");
            }
        }

        public void Delete(string accountantId)
        {
            _accountants.RemoveAll(x => x.AccountantId == accountantId);
        }

        public List<IAccountant> GetAll()
        {
            return _accountants;
        }

        public IAccountant GetById(string accountantId)
        {
            return _accountants.FirstOrDefault(x => x.AccountantId == accountantId);
        }
    }
}
