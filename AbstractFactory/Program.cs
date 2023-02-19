
using AbstractFactory;

public class program
{
    /* O padrão do abstract factory é criar classes abstratas que utiliza 
     * o conceito de multiplas interfaces gráficas.
     * Este permite que a aplicação acesse diretamente as classes concretas.
     */
    static void Main(string[] args)
    {
        Console.WriteLine("Fábrica");

        IAbstractFactory factory = new Factory();
        Console.WriteLine(factory.CreateDoor().GetName());
        Console.WriteLine(factory.CreateWindow().GetName());
        Console.WriteLine(factory.CreateRoof().GetColor());

        Console.WriteLine("   ");

        Console.WriteLine("Bazar");

        IAbstractFactory factoryBazar = new FactoryBazar();
        Console.WriteLine(factoryBazar.CreateDoor().GetName());
        Console.WriteLine(factoryBazar.CreateWindow().GetName());
        Console.WriteLine(factoryBazar.CreateRoof().GetColor());
    }
}