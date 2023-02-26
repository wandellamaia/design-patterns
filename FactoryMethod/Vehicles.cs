using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class SkateInLine : Vehicle
    {
        public readonly int wheels;

        public SkateInLine()
        {
            this.wheels = 8;
        }
        public override int NumberWheels()
        {
            return wheels;
        }

        public override string VehicleType()
        {
            return "Skate In Line";
        }
    }
    public class Car : Vehicle
    {
        private readonly int wheels;
        public Car()
        {
            this.wheels = 4;
        }
        public override int NumberWheels()
        {
            return this.wheels;
        }
        public override string VehicleType()
        {
            return "Car";
        }
    }
    public class Bike: Vehicle
    {
        private readonly int wheels;
        public Bike() {
            this.wheels = 2;
        }
        public override int NumberWheels()
        {
            return this.wheels;
        }
        public override string VehicleType()
        {
            return "Bicycle";
        }
    }
}
