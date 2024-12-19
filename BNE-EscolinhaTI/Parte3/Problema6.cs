using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Vamos calcular os Valores Futuros!");
            int numeroCasos = 3;

            for (int i = 0; i < numeroCasos; i++)
            {
                Console.WriteLine("========================================");
                Console.WriteLine($"\nCaso {i + 1}:");

                Console.Write("\nInforme o valor inicial: R$");
                double valorInicial = double.Parse(Console.ReadLine());

                Console.Write("Informe a taxa de juros (%): ");
                double taxaJuro = double.Parse(Console.ReadLine()) / 100; 

                Console.Write("Informe o período em meses (com valores decimais, por exemplo, 8.3): ");
                double periodoMes = double.Parse(Console.ReadLine());  

                // Exibindo os detalhes do caso
                Console.WriteLine($"Valor Inicial: R${valorInicial:F2}");
                Console.WriteLine($"Taxa de Juros: {taxaJuro * 100:F2}%");
                Console.WriteLine($"Período: {periodoMes} meses\n");

                for (int mes = 1; mes <= (int)periodoMes; mes++)
                {
                    double valorFinal = valorInicial * Math.Pow(1 + taxaJuro, mes);

                    Console.WriteLine($"Mês {mes}: R${valorFinal:F2}");
                }

                double valorFinalExtra = valorInicial * Math.Pow(1 + taxaJuro, periodoMes);

                Console.WriteLine($"\nValor Final após {periodoMes} meses: R${valorFinalExtra:F2}");
                Console.WriteLine(); 

            }
        }
    }
}
