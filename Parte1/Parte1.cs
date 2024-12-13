using System;

namespace Parte1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Seja bem vindo ao Programa 1:\n" +
                "\n 1 - Problema 1" +
                "\n 2 - Problema 2" +
                "\n 3 - Problema 3");

            Console.Write("\nInsira a opção de problema que deseja consultar: ");
            int mod = int.Parse(Console.ReadLine());

            switch (mod)
            {
                case 1:
                    Console.Write("Insira o valor da variável A: ");
                    int a1 = int.Parse(Console.ReadLine());

                    Console.Write("Insira o valor da variável B: ");
                    int b1 = int.Parse(Console.ReadLine());

                    int c1 = 0; // Inicializa a variável c

                    int[] v1 = new int[a1]; // Inicializa o vetor  v 

                    c1 = (a1 + b1) / 2;

                    c1 = c1 - 40;

                    v1[3] = a1 + b1 + c1;

                    Console.WriteLine($"A = {a1}");
                    Console.WriteLine($"B = {b1}");
                    Console.WriteLine($"C = {c1}");
                    Console.WriteLine($"O quarto item do vetor é o número: {v1[3]}");

                    break;

                case 2:
                    /*Console.Write("Informe o valor da variável A: "); 
                    int a = int.Parse(Console.ReadLine());*/

                    int a2 = 2;

                    int[] v2 = new int[7];

                    while (a2 < 6)
                    {
                        v2[a2] = 10 * a2;

                        Console.WriteLine($"{a2}");
                        Console.WriteLine($"{v2[a2]}");

                        a2 += 1;
                    }

                    Console.WriteLine(a2);

                    break;

                case 3:

                    /* Console.WriteLine("Informe um valor para a variável a: ");
                    int a = int.Parse(Console.ReadLine());
                    Console.WriteLine("Informe um valor para a variável b: ");
                    int b = int.Parse(Console.ReadLine());*/

                    int a3 = 7;
                    int b3 = a3 - 6;

                    int[] v3 = new int[a3];

                    while (b3 < a3)
                    {
                        v3[b3] = b3 + a3;
                        b3 += 2;

                        Console.WriteLine(b3);
                    }

                    break;
            }
        }
    }
}
