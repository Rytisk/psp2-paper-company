using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accounting;

namespace AccountingRepository.Payment
{
    class InMemoryPaymentRepository
    {
        private List<IPayment> _payments = new List<IPayment>();

        public void Add(IPayment payment)
        {
            if (!_payments.Any(x => x.PaymentId == payment.PaymentId))
            {
                _payments.Add(payment);
            }
            else
            {
                throw new Exception("This payment record already exists.");
            }
        }

        public void Delete(int paymentId)
        {
            _payments.RemoveAll(x => x.PaymentId == paymentId);
        }

        public List<IPayment> GetAll()
        {
            return _payments;
        }

        public IPayment GetById(int paymentId)
        {
            return _payments.FirstOrDefault(x => x.PaymentId == paymentId);
        }
    }
}
