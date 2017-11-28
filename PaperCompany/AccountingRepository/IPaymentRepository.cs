using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accounting;

namespace AccountingRepository
{
    interface IPaymentRepository
    {
        void Add(IPayment payment);
        void Delete(int paymentId);
        IPayment GetById(int paymentId);
        List<IPayment> GetAll();
    }
}
