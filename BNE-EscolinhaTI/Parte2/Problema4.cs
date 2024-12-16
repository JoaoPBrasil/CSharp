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

            Console.Write("Informe a Taxa de Juros (insira o valor com vírgula): ");
            decimal x = decimal.Parse(Console.ReadLine());
            decimal taxaJuros = x / 100;

            Console.Write("Informe o Período Mensal: ");
            int periodoMes = int.Parse(Console.ReadLine());

            Console.Write("Deseja realizar um saque durante o período (Digite 'sim' ou 'nao'): ");
            string respSaque = Console.ReadLine().ToLower();

            decimal valorSaque = 0;
            int mesSaque = 0;

            if (respSaque == "sim")
            {
                Console.Write("Em qual mês será realizado o saque: ");
                mesSaque = int.Parse(Console.ReadLine());

                Console.Write("Qual será a quantia que deseja retirar da conta: R$");
                valorSaque = decimal.Parse(Console.ReadLine());
            }

            Console.WriteLine("===========================================================");

            decimal valorAcumulado = valorPresente;

            for (int mes = 1; mes <= periodoMes; mes++)
            {
                decimal valorFuturo = valorAcumulado * (1 + taxaJuros * mes);

                if (respSaque == "sim" && mes == mesSaque)
                {
                    valorFuturo -= valorSaque; 
                    valorAcumulado = valorFuturo; 
                    Console.WriteLine($"Saque de R${Math.Round(valorSaque, 2)} realizado no {mes}º mês");
                }

                Console.WriteLine($"Após o {mes}º mês, o valor acumulado será igual à: R${Math.Round(valorFuturo, 2)}");
            }

        }
    }
}
