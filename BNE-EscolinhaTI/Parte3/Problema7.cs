using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Vamos calcular os Valores Futuros!");
        int numeroCasos = 3;

        for (int i = 0; i < numeroCasos; i++)
        {
            Console.WriteLine("========================================");
            Console.WriteLine($"\nCaso {i + 1}:");

            // Recebendo dados do usuário
            Console.Write("\nInforme o valor inicial: R$");
            double valorInicial = double.Parse(Console.ReadLine());

            Console.Write("Informe a taxa de juros (%): ");
            double taxaJuro = double.Parse(Console.ReadLine()) / 100;

            Console.Write("Informe o período em meses (Caso contenham dias insira o número com vírgula): ");
            double periodoMes = double.Parse(Console.ReadLine());

            Console.Write("Você deseja fazer o resgate no quinto mês? (s/n): ");
            string resgatarNoQuintoMes = Console.ReadLine().ToLower();

            int mesResgate = 5;
            if (resgatarNoQuintoMes != "s")
            {
                Console.Write("Em qual mês você deseja realizar o resgate: ");
                mesResgate = int.Parse(Console.ReadLine());
            }

            Investimento investimento = new Investimento(valorInicial, taxaJuro, periodoMes, mesResgate);

            investimento.ExibirTabelaResgates();
            Console.WriteLine();
        }
    }
}

class Investimento
{
    private double ValorInicial { get; set; }
    private double TaxaJuro { get; set; }
    private double PeriodoMes { get; set; }
    private int MesResgate { get; set; }

    public Investimento(double valorInicial, double taxaJuro, double periodoMes, int mesResgate)
    {
        ValorInicial = valorInicial;
        TaxaJuro = taxaJuro;
        PeriodoMes = periodoMes;
        MesResgate = mesResgate;
    }

    public void ExibirTabelaResgates()
    {
        double saldoLiquido = ValorInicial;
        double rendimentoMensalAcumulado = 0;
        double rendimentoRestante = 0;
        double rendimentoAnterior = 0;

        Console.WriteLine("\nTabela de Resgates:");
        Console.WriteLine("-----------------------------------------------------------");
        Console.WriteLine($"{"Mês",-5} {"Valor Presente Investido",-25} {"Rendimento Mensal",-20} {"Saldo Liquido Restante",-25} {"Rendimento Restante",-20}");

        for (int mes = 1; mes <= (int)PeriodoMes; mes++)
        {
            // Calcular o valor final do mês
            double valorFinalMes = saldoLiquido * Math.Pow(1 + TaxaJuro, mes);
            double rendimentoAtual = valorFinalMes - saldoLiquido;

            if (mes < MesResgate)
            {
                // Exibindo os dados até o mês de resgaste
                Console.WriteLine($"{mes,-5} {1000,-25:F2} {rendimentoAtual,-20:F2} {valorFinalMes,-25:F2} {rendimentoRestante,-20:F2}");
                rendimentoMensalAcumulado = rendimentoAtual;
                rendimentoRestante = rendimentoAtual;
                rendimentoAnterior = rendimentoAtual;
            }
            else if (mes == MesResgate)
            {
                // Exibe a mensagem de saque realizado no mês de resgaste
                Console.WriteLine($"{mes,-5} {"Saque realizado",-25} {"Saque realizado",-20} {"Saque realizado",-25} {"Saque realizado",-20}");
                saldoLiquido = ValorInicial; // Reinicia o saldo
                rendimentoRestante = 0; // O rendimento restante é zero após o saque
            }
            else
            {
                // Após o resgaste, reinicia os valores dos meses
                int mesCiclo = (mes - MesResgate) % MesResgate; // Calcula o mês no ciclo (mês 6 = mês 1, mês 7 = mês 2, etc.)
                if (mesCiclo == 0) mesCiclo = MesResgate; // Se o cálculo der 0, significa que deve reiniciar o ciclo.

                // Recalcula o rendimento para os meses após o saque
                double rendimentoRestaurado = ValorInicial * TaxaJuro;

                // Exibe os dados após o reinício do saldo
                Console.WriteLine($"{mes,-5} {1000,-25:F2} {rendimentoRestaurado,-20:F2} {1000,-25:F2} {rendimentoRestante,-20:F2}");
                saldoLiquido += rendimentoRestaurado; // Atualiza o saldo após o rendimento
            }
        }

        // Exibindo o valor final após o período total
        double valorFinalTotal = saldoLiquido * Math.Pow(1 + TaxaJuro, PeriodoMes);
        Console.WriteLine($"\nValor Inicial: R${ValorInicial:F2}");
        Console.WriteLine($"Rendimento Total: R${valorFinalTotal - ValorInicial:F2}");
        Console.WriteLine($"Valor Final após {PeriodoMes} meses: R${valorFinalTotal:F2}");
        Console.WriteLine($"Rendimento Resgatado: R${rendimentoAnterior:F2}");
    }
}
