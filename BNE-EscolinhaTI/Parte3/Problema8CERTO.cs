using System;

namespace JurosCompostos
{
    public class Investimento
    {
        public double ValorInicial { get; set; }
        public double TaxaJuros { get; set; }
        public int MesesCompletos { get; set; }
        public int DiasAdicionais { get; set; }

        public Investimento(double valorInicial, double taxaJuros, int mesesCompletos, int diasAdicionais)
        {
            ValorInicial = valorInicial;
            TaxaJuros = taxaJuros;
            MesesCompletos = mesesCompletos;
            DiasAdicionais = diasAdicionais;
        }

        public void ExibirTabelaComSaque(double saque, int mesSaque)
        {
            double saldoAtual = ValorInicial;  
            double saldoAnterior = ValorInicial;  
            double rendimento = 0;  

            Console.WriteLine("\nMês\tTaxa de Juros (%)\tValor Acumulado\tRendimento\tSaldo Líquido");

            for (int i = 1; i <= MesesCompletos; i++)
            {
                saldoAnterior = saldoAtual;  

                saldoAtual = saldoAtual * (1 + TaxaJuros / 100);

                rendimento = saldoAtual - saldoAnterior;

                if (i == mesSaque)
                {
                    if (saque > saldoAtual)
                    {
                        Console.WriteLine($"Saque no mês {i} não pode ser realizado, valor superior ao acumulado!");
                        break; 
                    }
                    saldoAtual -= saque;
                    Console.WriteLine($"Saque de R$ {saque:C2} realizado no mês {i}");
                }

                Console.WriteLine($"{i}\t{TaxaJuros:F2}\t\t{saldoAtual:C2}\t\t{rendimento:C2}\t\t{saldoAtual:C2}");
            }

            if (DiasAdicionais > 0)
            {
                Console.WriteLine($"\nApós {MesesCompletos} meses e {DiasAdicionais} dias (sem juros adicionais):");
                Console.WriteLine($"Valor final (sem juros para os dias adicionais): {saldoAtual:C2}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 3; i++) 
            {
                Console.WriteLine($"\n--- Investimento {i} ---");

                Console.Write("Digite o valor inicial do investimento: ");
                double valorInicial = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite a taxa de juros (% ao mês): ");
                double taxaJuros = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite o número de meses completos do investimento: ");
                int mesesCompletos = Convert.ToInt32(Console.ReadLine());

                Console.Write("Digite o número de dias adicionais (0 a 30): ");
                int diasAdicionais = Convert.ToInt32(Console.ReadLine());

                Console.Write("Digite o valor do saque: ");
                double saque = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite o mês para realizar o saque (1 a " + mesesCompletos + "): ");
                int mesSaque = Convert.ToInt32(Console.ReadLine());

                if (mesSaque < 1 || mesSaque > mesesCompletos)
                {
                    Console.WriteLine("Mês inválido. O mês deve estar entre 1 e " + mesesCompletos);
                    return; 
                }

                Investimento investimento = new Investimento(valorInicial, taxaJuros, mesesCompletos, diasAdicionais);

                investimento.ExibirTabelaComSaque(saque, mesSaque);
            }

            Console.ReadLine();
        }
    }
}
