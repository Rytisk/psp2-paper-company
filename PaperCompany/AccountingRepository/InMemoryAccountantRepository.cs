using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaperCompany.Entities.AccountingApi;
using PaperCompany.Repository.AccountingRepositoryApi;

namespace PaperCompany.Repository.AccountingRepositoryInMemory
{
    public class InMemoryAccountantRepository : IAccountantRepository
    {
        private List<IAccountant> _accountants = new List<IAccountant>();

        public void Add(IAccountant accountant)
        {
            if (!_accountants.Any(x => x.AccountantId == accountant.AccountantId))
            {
                _accountants.Add(accountant);
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
