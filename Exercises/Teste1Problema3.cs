using System;

namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {
           /* Console.WriteLine("Informe um valor para a variável a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe um valor para a variável b: ");
            int b = int.Parse(Console.ReadLine());*/

            int a = 7;
            int b = a - 6;

            int[] v = new int[a];

            while (b < a)
            {
                v[b] = b + a;
                b += 2;

                Console.WriteLine(b);
            }
        }
    }
}
