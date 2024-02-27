using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniUber
{
    public class Vehicle
    {
        private string plateNumber;
        private string vehicleType;
        private string model;

        public string PlateNumber
        { get { return plateNumber; } set { plateNumber = value; } }

        public string Model
        { get { return model; } set { model = value; } }

        public string VehicleType
        { get { return vehicleType; } set { vehicleType = value; } }
    }
}
