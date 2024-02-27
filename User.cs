using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniUber
{
    public class User : Person
    {
        protected string username;
        protected string password;
        protected CreditCard card;
        public User(string Fname,string Lname, string PhoneNumber,string Username,string Password) : base(Fname, Lname, PhoneNumber)
        {
            this.username = Username;
            this.password = Password;
            card = new CreditCard();
        }
       

        public string Username
        { get { return username; } set { username = value; } }
        public string Password
        { get { return password; } set { password = value; } }
        
        public CreditCard Card { get { return card; } set { card = value;} }

    }
}
