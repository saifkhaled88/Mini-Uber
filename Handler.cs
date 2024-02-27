using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Uber
{
   public abstract class  Handler
    {
        protected Handler next_in_chain;
        protected  DbProxy database = DbProxy.GetDB();

        public void set_next(Handler h)
        {
            next_in_chain = h;
        }

        public abstract void handle_request(Ticket t);
        
    }
}
