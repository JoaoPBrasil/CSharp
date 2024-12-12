using System.Runtime.InteropServices;

class Progam
{
    static void Main()
    {
        int? i = 10;
        int? i2 = i;
        i2 = 20;

        i = null;

        if (i is null)
        {
            Console.WriteLine("Nulo");
        }
        else if (i is not null)
        {
            Console.WriteLine("Não é nulo");
        }

        Console.WriteLine(i.HasValue);
        Console.WriteLine(i.Value);
        Console.WriteLine(i.GetValueOrDefault(1));

        Test t = new Test();
        t.X = 12;

        t = null;

        Test t2 = t;
        t2 = new Test();
        t2.X = 20;

        Console.WriteLine(t.X);
    }

    class Test
    {
        public int X;
    }
}
