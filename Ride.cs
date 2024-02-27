using MiniUber;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern
{
    public abstract class RidePrice //factor
    {
        public Driver driver;

        public User user;
        public double price{ get; set; }
        public string From { get; set; }
        public string To { get; set; }

        

        public abstract double CalculatePrice(int from,int to);
    }
}
