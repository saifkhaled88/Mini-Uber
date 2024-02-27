using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniUber
{
    public class User : Person
    {
        public User(string Fname,string Lname, string PhoneNumber) : base(Fname, Lname, PhoneNumber)
        {
        }
        protected string username;
        protected string password;
        protected CreditCard card;

        public string Password
        { get { return password; } set { password = value; } }
        
        public CreditCard Card { get { return card; } set { card = value;} }

        public void RequestRide()
        {
            
        }

        public void CancelRide()
        {
            
        }
    }
}
