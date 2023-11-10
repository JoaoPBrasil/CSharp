using System;

namespace Aula7
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Insira três valores: ");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            int resultado = Maior(n1, n2, n3);

            Console.WriteLine($"Maior = {resultado}");

        }

        static int Maior(int a, int b, int c)
        {
            int resultado;
            if(a > b && a > c)
            {
                resultado = a; 
            }
            else if(b > c)
            {
                resultado = b;
            }
            else
            {
                resultado = c;
            }

            return resultado;
        }
    }
}
