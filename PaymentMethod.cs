using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniUber
{
    public interface PaymentMethod
    {
       void Pay(float amount);
    }
}
