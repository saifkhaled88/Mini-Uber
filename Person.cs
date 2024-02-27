using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniUber
{
    public abstract class Person
    {
    
        private string fname;
        private string lname;
        private string phoneNumber;

        public Person(String Fname,String Lname, String PhoneNumber)
        {
            fname = Fname;
            lname = Lname;
            phoneNumber = PhoneNumber;
        }

        public string Fname
        {
            get { return fname; } 
            set { fname = value; }
        }

        public string Lname
        {
            get { return lname; }
            set { lname = value; }
        }
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }


    }
}
