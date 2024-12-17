using System;

namespace CalculoInvestimento
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vamos calcular o Rendimento de um investimento!");

            Console.Write("Informe o Valor Futuro (VF): R$");
            decimal valorFuturo = decimal.Parse(Console.ReadLine());

            Console.Write("Informe o Período (em anos): ");
            int periodoAno = int.Parse(Console.ReadLine());
            int periodoMes = periodoAno * 12;

            Console.Write("Informe a Taxa de Juros (mensal, em %): ");
            decimal taxaJuros = decimal.Parse(Console.ReadLine()) / 100;

            decimal valorInicial = valorFuturo / (decimal)Math.Pow((1 + (double)taxaJuros), periodoMes);

            Console.WriteLine($"O Valor Inicial (VP) necessário para alcançar R${valorFuturo} em {periodoAno} anos será de R${Math.Round(valorInicial, 2)}.");

            /*Valor Futuro: R$7.390,61
              Periodo em anos: 2
              Taxa de juros: 1,25*/

        }
    }
}
