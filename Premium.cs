using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Design_Pattern;
using MiniUber;

//Ride 
//Routing

namespace Design_Pattern
{
    class Premium : RidePrice
    {
        public override double CalculatePrice(int from, int to)
        {
            _price = Routing.dist[from, to] * 2;
          return _price ;
        }

        private double _price =0;
        public double Price {
            get
            {
                return _price;
            }
        }
        public Premium(Driver _driver,User _user,string _from ,string _to)
        {
            this.driver = _driver;
            this.user = _user;
            this.From = _from;
            this.To = _to;

        }

    }
}
