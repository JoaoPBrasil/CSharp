class Progam
{
    static void Main()
    {
        string[] names = {"Joao", "Pedro", "Brasil"};

        if (names[0] == "Joao")
        {
            Console.WriteLine("Igual");
        }

        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
    }

    /*static void Main()
    {
        string[] names = {"Joao", "Pedro", "Brasil"};

        if (string.Equals(names[0], "Joao", StringComparison.OrdinalIgnoreCase)
        {
            Console.WriteLine("Igual");
        }

        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
    }*/
}
