using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class VehicleFactory
    {
        private string type;
        public VehicleFactory(string type)
        {
            this.type = type;
        }
        public static IVehicleFactory getVehicle(string type)
        {
            switch (type)
            {
                case "bike": return new Bike();
                default: return null;
            }
        }
    }
}
