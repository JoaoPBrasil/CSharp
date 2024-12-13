using System;

namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Insira o valor da variável A: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Insira o valor da variável B: ");
            int b = int.Parse(Console.ReadLine());

            int c = 0; // Inicializa a variável c

            int[] v = new int[a]; // Inicializa o vetor  v 

            c = (a + b) / 2;

            c = c - 40;

            v[3] = a + b + c;

            Console.WriteLine($"A = {a}");
            Console.WriteLine($"B = {b}");
            Console.WriteLine($"C = {c}");
            Console.WriteLine($"O quarto item do vetor é o número: {v[3]}");
        }
    }
}
