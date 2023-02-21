
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

        UserFactory(new Factory());

        Console.WriteLine("   ");

        Console.WriteLine("Bazar");

        UserFactory(new FactoryBazar());
    }

    public static void UserFactory(IAbstractFactory factory)
    {
        Console.WriteLine(factory.CreateDoor().GetName());
        Console.WriteLine(factory.CreateWindow().GetName());
        Console.WriteLine(factory.CreateRoof().GetColor());
    }
}