using System;

class Program
{
    static void Main()
    {
        Console.Write("Informe o valor inicial investido: R$");
        double valorInicial = Convert.ToDouble(Console.ReadLine());

        Console.Write("Informe a taxa de juros mensal (por exemplo, 0.02 para 2%): ");
        double taxaJuros = Convert.ToDouble(Console.ReadLine());

        Console.Write("Informe o período de meses: ");
        int periodoMeses = Convert.ToInt32(Console.ReadLine());

        Investimento investimento = new Investimento(valorInicial, taxaJuros, periodoMeses);

        investimento.ExibirTabela();

        Console.Write("\nVocê deseja realizar um saque? (s/n)");
        string resposta = Console.ReadLine();

        if (resposta.ToLower() == "s")
        {
            Console.Write("Informe o valor do saque: R$");
            double valorSaque = Convert.ToDouble(Console.ReadLine());
            investimento.RealizarSaque(valorSaque);
        }

        Console.WriteLine($"\nSaldo final do investimento: {investimento.SaldoLiquido:C2}");
    }


    public class Investimento
{
    public double ValorInicial { get; set; }
    public double TaxaJuros { get; set; }
    public int PeriodoMeses { get; set; }
    public double SaldoLiquido { get; set; }

    public Investimento(double valorInicial, double taxaJuros, int periodoMeses)
    {
        ValorInicial = valorInicial;
        TaxaJuros = taxaJuros;
        PeriodoMeses = periodoMeses;
        SaldoLiquido = valorInicial;
    }

    public void ExibirTabela()
    {
        Console.WriteLine("\nTabela de Investimento:");
        Console.WriteLine("Mês | Valor Inicial | Taxa de Juros (%) | Rendimento | Saldo Líquido");

        for (int i = 1; i <= PeriodoMeses; i++)
        {
            double rendimento = SaldoLiquido * TaxaJuros;
            SaldoLiquido += rendimento;
            Console.WriteLine($"{i,3} | {ValorInicial,15:C2} | {TaxaJuros * 100,17:F2} | {rendimento,10:C2} | {SaldoLiquido,13:C2}");
        }
    }

    public void RealizarSaque(double valorSaque)
    {
        if (valorSaque <= SaldoLiquido)
        {
            SaldoLiquido -= valorSaque;
            Console.WriteLine($"Saque de {valorSaque:C2} realizado. Saldo restante: {SaldoLiquido:C2}");
        }
        else
        {
            Console.WriteLine("Saldo insuficiente para o saque.");
        }
    }
}

}
