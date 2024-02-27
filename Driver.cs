using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniUber
{
    public class Driver : Person
    {
        public Driver(string Fname, string Lname, string PhoneNumber) : base(Fname, Lname, PhoneNumber)
        {
        }
        protected string vehicle;
        protected int ssn;
        protected string carType;
        protected string plateNumber;

        public int SSN
        { get { return ssn; } set { ssn = value; } }

        public string CarType
        { get { return carType; } set { carType = value; } }

        public string PlateNumber
        { get { return plateNumber; } set { plateNumber = value; } }
    }
}
