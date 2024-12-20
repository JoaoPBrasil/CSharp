using System;

namespace JurosCompostos
{
    // Classe que representa o Investimento
    public class Investimento
    {
        public double ValorInicial { get; set; }
        public double TaxaJuros { get; set; }
        public int PeriodoMeses { get; set; }

        // Construtor para inicializar os valores
        public Investimento(double valorInicial, double taxaJuros, int periodoMeses)
        {
            ValorInicial = valorInicial;
            TaxaJuros = taxaJuros;
            PeriodoMeses = periodoMeses;
        }

        // Método para calcular o valor a cada mês, considerando um saque
        public void ExibirTabelaComSaque(double saque, int mesSaque)
        {
            double saldoAtual = ValorInicial;  // Saldo inicial

            Console.WriteLine("\nMês\tTaxa de Juros (%)\tValor Acumulado\tSaldo Líquido");

            for (int i = 1; i <= PeriodoMeses; i++)
            {
                // Calcula o valor acumulado com juros compostos
                saldoAtual = saldoAtual * (1 + TaxaJuros / 100);

                // Realiza o saque no mês escolhido
                if (i == mesSaque)
                {
                    if (saque > saldoAtual)
                    {
                        Console.WriteLine($"Saque no mês {i} não pode ser realizado, valor superior ao acumulado!");
                        break; // Se o saque for maior que o saldo, interrompe a execução
                    }
                    saldoAtual -= saque;  // Subtrai o valor do saque
                    Console.WriteLine($"Saque de R$ {saque:C2} realizado no mês {i}");
                }

                // Exibe as informações de cada mês
                Console.WriteLine($"{i}\t{TaxaJuros:F2}\t\t{saldoAtual:C2}\t\t{saldoAtual:C2}");
            }
        }
    }

    // Classe principal que executa o programa
    class Program
    {
        static void Main(string[] args)
        {
            // Entrada de dados
            Console.Write("Digite o valor inicial do investimento: ");
            double valorInicial = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a taxa de juros (% ao mês): ");
            double taxaJuros = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o período do investimento em meses: ");
            int periodoMeses = Convert.ToInt32(Console.ReadLine());

            // Entrada do saque
            Console.Write("Digite o valor do saque: ");
            double saque = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o mês para realizar o saque (1 a " + periodoMeses + "): ");
            int mesSaque = Convert.ToInt32(Console.ReadLine());

            // Verifica se o mês do saque é válido
            if (mesSaque < 1 || mesSaque > periodoMeses)
            {
                Console.WriteLine("Mês inválido. O mês deve estar entre 1 e " + periodoMeses);
                return; // Interrompe o programa em caso de mês inválido
            }

            // Criando o objeto Investimento com os dados recebidos
            Investimento investimento = new Investimento(valorInicial, taxaJuros, periodoMeses);

            // Exibindo a tabela com o valor acumulado e saldo líquido mês a mês, considerando o saque
            investimento.ExibirTabelaComSaque(saque, mesSaque);

            // Pausar para ver o resultado
            Console.ReadLine();
        }
    }
}
