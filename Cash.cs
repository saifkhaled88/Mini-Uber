using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniUber
{
    public class Cash : PaymentMethod
    {
        public void Pay(float amount)
        {
            Console.WriteLine("Customer pays" + amount + "using Cash");
        }
    }
}
