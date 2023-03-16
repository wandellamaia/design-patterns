namespace Facade
{
    public class Program
    {
        static void Main(string[] args)
        {
            Door door = new Door();
            Roof roof = new Roof();
            Facade facade = new Facade(door, roof);
            Console.WriteLine(facade.Object());
        }
    }
}

