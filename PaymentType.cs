using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniUber
{
    public class PaymentType
    {
        private PaymentMethod paymentMethod;

        public void SetPaymentMethod(PaymentMethod paymentMethod)
        {
            this.paymentMethod = paymentMethod;
        }

        public void PaymentChoice(float amount)
        {
            this.paymentMethod.Pay(amount);
        }
    }
}
