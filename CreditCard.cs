using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniUber
{
    public class CreditCard : PaymentMethod
    {
   
        private string cardNumber;
        private string cVV;
        public string CardNumber
        { get { return cardNumber; } set { cardNumber = value; } }
     
        public string CVV
        { get { return cVV; } set { cVV = value; } }

        public void Pay(float amount)
        {
            Console.WriteLine("Customer pays" + amount + "using Credit Card");
        }
    }
}
