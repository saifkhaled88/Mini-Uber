using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Uber
{
    class Sleepy : Handler
    {
        public override void handle_request(Ticket t)
        {
            if (t.Type.ToLower() == "sleepy driver")
            {
                database.InsertTicket(t);

            }
            else
            {
                next_in_chain.handle_request(t);
            }


        }

    }
}
