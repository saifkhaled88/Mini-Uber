﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Uber
{
    class vehicle_unsafe : Handler
    {
        public override void handle_request(Ticket t)
        {
            if(t.Type.ToLower()=="vehicle unsafe")
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
