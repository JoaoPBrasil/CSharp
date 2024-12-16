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

            Console.Write("Informe o Percentual de Juros: ");
            decimal percentualJuros = decimal.Parse(Console.ReadLine());

            decimal valorFuturo = valorPresente * (decimal)Math.Pow((double)(1 + taxaJuros), periodoMes);

            decimal total = Math.Round(valorFuturo, 2);


            Console.WriteLine("=================================");
            Console.WriteLine($"O valor futuro será: R${total}");


            /*decimal valorPresente = 1000m;
            decimal taxaJuros = 5.30m / 100;
            int periodoMes = 10;
            decimal percentualJuros = 2m;*/

        }
    }
}
