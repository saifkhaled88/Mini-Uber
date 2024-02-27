using Design_Pattern;
using MiniUber;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Uber
{
    class UserNameExist : IValidation
    {
        IValidation goNxt;
        public override void setNext(IValidation nxt)
        {
            database = DbProxy.GetDB();
            goNxt = nxt;
            
        }

        public override void valid(User ch)
        {
           User u = database.GetUser(ch.Username);
            if (u == null)
            {
                counter++;
                goNxt.valid(ch);
            }
            
            


            
        }
    }
}
