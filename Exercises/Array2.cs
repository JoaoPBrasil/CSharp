using System.Runtime.CompilerServices;

class Program
{
    static void Main()
    {
        string[] names = { "Joao", "Pedro", "Brasil"};

        Console.WriteLine(names[0]);
        Console.WriteLine(names[1]);
        Console.WriteLine(names[2]);

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine(names[i]);
        }
    }

        /*static void Main()
    {
        string[] names = { "Joao", "Pedro", "Brasil"};

        for (int i = 0; i < names.Length; i++)
        {
            Console.WriteLine(names[i]);
        }
    }*/

    /*static int Main()
    {
        string[] names = { "Joao", "Pedro"};

        return 1
    }*/

    
}

