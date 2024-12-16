using System;

namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vamos calcular o Rendimento de um investimento!");

            Console.Write("Informe o Valor Presente: ");
            decimal valorPresente = decimal.Parse(Console.ReadLine());

            Console.Write("Informe a Taxa de Juros (insira o valor com vírgula): ");
            decimal x = decimal.Parse(Console.ReadLine());
            decimal taxaJuros = x / 100;

            Console.Write("Informe o Período Mensal: ");
            int periodoMes = int.Parse(Console.ReadLine());

            Console.WriteLine("====================================");

            decimal rG = 0m;
            decimal rA = valorPresente;

            for (int y = 1; y <= periodoMes; y++)
            {
                // Cálculo do rendimento mensal (juros sobre o valor acumulado)
                decimal rendimentoMensal = rA * taxaJuros;

                // Rendimento acumulado
                rA += rendimentoMensal;

                Console.WriteLine($"No {y}º mês:");
                Console.WriteLine($"O rendimento do mês será de R${Math.Round(rendimentoMensal, 2)}.");
                Console.WriteLine($"A Renda Acumulada até o momento será de R${Math.Round(rA, 2)}.");
                Console.WriteLine("------------------------------------------------------");


                /*decimal valorPresente = 3800m;
                decimal taxaJuros = 1,25m / 100;
                int periodoMes = 6;
                decimal percentualJuros = 0,5m;*/

            }

        }
    }
}
