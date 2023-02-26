namespace FactoryMethod
{
    class Program
    {
        /*
         Este tipo de designer, é um dos mais utilizados.
            Ele permite que deixe o código mais flexivél ao criar mais objetos.
         */
        static void Main()
        {
            VehicleCode(new SkateInLine());
            VehicleCode(new Bike());
            VehicleCode(new Car());
        }

        public static void VehicleCode(Vehicle vehicleFactory)
        {
            Console.WriteLine(vehicleFactory.VehicleType());
            Console.WriteLine(vehicleFactory.NumberWheels());
        }
    }
}
