using System;

namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vamos calcular o Rendimento de um investimento!");

            Console.Write("Informe o Valor Presente: R$");
            decimal valorPresente = decimal.Parse(Console.ReadLine());

            Console.Write("Informe a Taxa de Juros (insira o valor com vírgula, exemplo 1,5 para 1,5%): ");
            decimal x = decimal.Parse(Console.ReadLine());
            decimal taxaJuros = x / 100;

            Console.Write("Informe o Número de Anos para calcularmos: ");
            int periodoAno = int.Parse(Console.ReadLine());
            int periodoMes = periodoAno * 12;

            Console.WriteLine("=================================");

            decimal valorAcumulado = valorPresente;

            for (int mes = 1; mes <= periodoMes; mes++)
            {
                // Calculando o valor do investimento para aquele mês
                valorAcumulado *= (1 + taxaJuros);

                Console.WriteLine($"Após o {mes}º mês, o valor acumulado será: R${Math.Round(valorAcumulado, 2)}");
            }

            Console.WriteLine("=================================");
            Console.WriteLine($"O valor final após {periodoAno} ano(s) será: R${Math.Round(valorAcumulado, 2)}");


            /*decimal valorPresente = 68m;
            decimal taxaJuros = 2,0m / 100;
            int periodoAno= 3;*/
        }

    }
}
