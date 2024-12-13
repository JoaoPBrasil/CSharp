using System;

namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.Write("Informe o valor da variável A: "); 
            int a = int.Parse(Console.ReadLine());*/

            int a = 2;

            int[] v = new int[7];
            
            while (a < 6)
            {
                v[a] = 10 * a;

                Console.WriteLine($"{a}");
                Console.WriteLine($"{v[a]}");

                a += 1;
            }

            Console.WriteLine(a);
        }
    }
}
