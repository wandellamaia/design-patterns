using Singleton;

public class Program
{
    // Padrão de projeto no geral pouco utilizado
    static void Main()
    {
        Produto variavelSingleton = new Produto();
        variavelSingleton.Name = "Software Singleton";
        Console.WriteLine(variavelSingleton.Name);

        Console.Read();
    }
}
