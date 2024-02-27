using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniUber
{
    public class Driver : Person
    {
        private Vehicle vehicle;

        public Driver(string Fname, string Lname, string PhoneNumber) : base(Fname, Lname, PhoneNumber)
        {
            vehicle = new Vehicle();
        }
        protected string ssn;
        

        public string SSN
        { get { return ssn; } set { ssn = value; } }

        public string CarType
        { get { return vehicle.VehicleType; } set { vehicle.VehicleType= value; } }

        public string PlateNumber
        { get { return vehicle.PlateNumber; } set { vehicle.PlateNumber = value; } }

        public Vehicle Vehicle { get => vehicle; set => vehicle = value; }
    }
}
