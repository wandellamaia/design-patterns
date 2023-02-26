namespace FactoryMethod
{
    class Program
    {
        static void Main()
        {
            new VehicleFactory("bike");
        }

        public void VehicleCode(IVehicleFactory vehicleFactory)
        {
            Console.WriteLine(vehicleFactory.VehicleType());
            Console.WriteLine(VehicleFactory.getVehicle("bike").NumberWheels());
        }
    }
}
