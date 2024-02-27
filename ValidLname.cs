using Design_Pattern;
using MiniUber;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Mini_Uber
{
    class ValidLname : IValidation
    {
        IValidation goNxt;
        public override void setNext(IValidation nxt)
        {
            
            goNxt = nxt;
        }
        
        public override void valid(User ch)
        {
            if (ch.Lname == null)
            {
                Console.WriteLine("Please Enter Name");
                return;
            }

            string name = ch.Lname;
            bool flag = false;

            string pattern = @"^[A-Za-z\s]+$";
            Regex regex = new Regex(pattern);
            Match match = regex.Match(name);

            flag = match.Success;


            if (flag == true)
            {
                counter++;
                goNxt.valid(ch);
                
            }
            else
            {
                //Console.WriteLine("NAME NOT VALID");
            }

        }
    }
}
