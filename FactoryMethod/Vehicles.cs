using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class Vehicles
    {
    }
    public class Car : IVehicleFactory
    {
        private readonly int Wheels;
        public Car()
        {
            this.Wheels = 4;
        }
        public int NumberWheels()
        {
            return this.Wheels;
        }
        public string VehicleType()
        {
            return "Car";
        }
    }
    public class Bike: IVehicleFactory
    {
        private readonly int Wheels;
        public Bike() {
            this.Wheels = 2;
        }
        public int NumberWheels()
        {
            return this.Wheels;
        }
        public string VehicleType()
        {
            return "Bicycle";
        }
    }
}
