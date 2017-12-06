using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Entities.AccountingApi;
using Company.Services.Api;
using Company.Repository.Api;

namespace Company.Services.Accounting
{
    public class NormalAccountantService : IAccountantService
    {
        private IAccountingFactory _accountingFactory;
        private IAccountantRepository _accountantRepository;


        public NormalAccountantService(IAccountingFactory accountingFactory, IAccountantRepository accountantRepository)
        {
            _accountingFactory = accountingFactory;
            _accountantRepository = accountantRepository;
        }

        public IAccountant CreateAccountant(string firstName, string lastName)
        {
            IAccountant accountant = _accountingFactory.CreateAccountant(firstName, lastName);
            _accountantRepository.Add(accountant);
            return accountant;
        }

        public List<IAccountant> GetAllAccountants()
        {
            return _accountantRepository.GetAll();
        }
    }
}
