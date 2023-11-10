using System;

namespace Exercicios_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a quantidade de testes: ");
            int testes = int.Parse(Console.ReadLine());
            double a, b, c;
            for (int i = 0; i < testes; i++)
            {
                Console.WriteLine("Informe o primeiro valor: ");
                a = double.Parse(Console.ReadLine());
                Console.WriteLine("Informe o segundo valor: ");
                b = double.Parse(Console.ReadLine());
                Console.WriteLine("Informe o terceiro valor: ");
                c = double.Parse(Console.ReadLine());
                double resultado = CalculamediaPonderada(a, b, c);
                Console.WriteLine($"Resultado da média ponderada: {resultado.ToString("N1")}");
            }

          static double CalculamediaPonderada(double a, double b, double c)
            {
                a = a * 0.2;
                b = b * 0.3;
                c = c * 0.5;
                double resultado = a + b + c;
                return resultado;
            }


        }
    }
}
