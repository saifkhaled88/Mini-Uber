using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Uber
{
    class Wallet : Handler
    {
        public override void handle_request(Ticket t)
        {
            if (t.Type.ToLower() == "wallet")
            {
                database.InsertTicket(t);


            }
            else
            {
            }


        }
    }
}
