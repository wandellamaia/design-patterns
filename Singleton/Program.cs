using Singleton;

public class Program
{
    // O padrão de projeto Singleton, tem apenas um ponto de acesso.
    // Logo, na implementação, é necessário fazer a verificação para que apenas uma instacia seja criada.
    static void Main()
    {
        Produto variavelSingleton = Produto.GetInstance();
        variavelSingleton.Name = "Software Singleton";

        Produto variavelSingleton2 = Produto.GetInstance();
        variavelSingleton2.Name = "Software Singleton 2";

        if(variavelSingleton== variavelSingleton2)
            Console.WriteLine(variavelSingleton2.Name);

        Console.Read();
    }
}
