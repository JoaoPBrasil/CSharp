class Progam
{
    static void Main()
    {
        int i = 10;

        if (int.TryParse("42", out int x))
        {
            Console.WriteLine("Sucesso !");
        }
        else
        {
            Console.WriteLine("Erro!");
        }

        if (int.TryParse("ab", out int x))
        {
            Console.WriteLine("Sucesso !");
        }
        else
        {
            Console.WriteLine("Erro!");
        }

        Console.WriteLine(x);
    }
}
