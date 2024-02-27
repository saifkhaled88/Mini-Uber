using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using MiniUber;

namespace Design_Pattern
{
    class ValidPhone : IValidation
    {

        IValidation goNxt;
        public override void setNext(IValidation nxt)
        {
            goNxt = nxt;
        }

        public override void valid(User ch)
        {
            if (ch.PhoneNumber == null)
            {
                //Console.WriteLine("Please Enter Phone Number");
                return;
            }
            
            string phone = ch.PhoneNumber;
            bool flag = false;

            string pattern = @"^01[0|1|2|5]\d{8}$";
            Regex regex = new Regex(pattern);
            Match match = regex.Match(phone);

            flag = match.Success;
            if (flag == true)
            {
                counter++;
                //Console.WriteLine($"ALL is Right {ch}");
            }
            else
            {
                //Console.WriteLine($"PHONE NOT VALID, {ch.PhoneNumber}");
            }

        }
    }
}
