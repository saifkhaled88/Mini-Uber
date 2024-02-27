using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using MiniUber;

namespace Design_Pattern
{
    class ValidFName : IValidation
    {
        IValidation goNxt;
        public override void setNext(IValidation nxt)
        {
            goNxt = nxt;
        }

        public override void valid(User ch)
        {
            if (ch.Fname == null)
            {
                Console.WriteLine("Please Enter Name");
                return;
            }

            string name = ch.Fname;
            bool flag = false;

            string pattern = @"^[A-Za-z\s]+$";
            Regex regex = new Regex(pattern);
            Match match = regex.Match(name);

            flag = match.Success;
            

            if (flag==true)
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
