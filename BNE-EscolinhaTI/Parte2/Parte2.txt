using System;

namespace CalculoInvestimento
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Seja bem vindo ao Programa 2:\n" +
                "\n 0 - Sair" +
                "\n 1 - Problema 1" +
                "\n 2 - Problema 2" +
                "\n 3 - Problema 3" +
                "\n 4 - Problema 4" +
                "\n 5 - Problema 5");

            Console.Write("\nInsira a opção do problema que deseja consultar: ");
            int mod = int.Parse(Console.ReadLine());

            switch (mod)
            {
                case 1:
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

                    break;
                }

                case 2:
                {

                        Console.WriteLine("Vamos calcular o Rendimento de um investimento!");

                        Console.Write("Informe o Valor Presente: ");
                        decimal vP2 = decimal.Parse(Console.ReadLine());

                        Console.Write("Informe a Taxa de Juros (insira o valor com vírgula): ");
                        decimal x2 = decimal.Parse(Console.ReadLine());
                        decimal tJ2 = x2 / 100;

                        Console.Write("Informe o Período Mensal: ");
                        int pM2 = int.Parse(Console.ReadLine());

                        Console.WriteLine("====================================");

                        decimal rG2 = 0m;
                        decimal rA2 = vP2;

                        for (int y2 = 1; y2 <= pM2; y2++)
                        {
                            // Cálculo do rendimento mensal (juros sobre o valor acumulado)
                            decimal rM2 = rA2 * tJ2;

                            // Rendimento acumulado
                            rA2 += rM2;

                            Console.WriteLine($"No {y2}º mês:");
                            Console.WriteLine($"O rendimento do mês será de R${Math.Round(rM2, 2)}.");
                            Console.WriteLine($"A Renda Acumulada até o momento será de R${Math.Round(rA2, 2)}.");
                            Console.WriteLine("------------------------------------------------------");


                            /*decimal valorPresente = 3800m;
                            decimal taxaJuros = 1,25m / 100;
                            int periodoMes = 6;
                            decimal percentualJuros = 0,5m;*/
                        }

                    break;
                }
            

                case 3:
                { 

                        Console.WriteLine("Vamos calcular o Rendimento de um investimento!");

                        Console.Write("Informe o Valor Presente: R$");
                        decimal vP3 = decimal.Parse(Console.ReadLine());

                        Console.Write("Informe a Taxa de Juros (insira o valor com vírgula, exemplo 1,5 para 1,5%): ");
                        decimal x3 = decimal.Parse(Console.ReadLine());
                        decimal tJ3 = x3 / 100;

                        Console.Write("Informe o Número de Anos para calcularmos: ");
                        int pA3 = int.Parse(Console.ReadLine());
                        int pM3 = pA3 * 12;

                        Console.WriteLine("=================================");

                        decimal vA3 = vP3;

                        for (int m3 = 1; m3 <= pM3; m3++)
                        {
                        
                            vA3 *= (1 + tJ3);

                            Console.WriteLine($"Após o {m3}º mês, o valor acumulado será: R${Math.Round(vA3, 2)}");
                        }

                        Console.WriteLine("=================================");
                        Console.WriteLine($"O valor final após {pA3} ano(s) será: R${Math.Round(vA3, 2)}");


                        /*decimal valorPresente = 68m;
                        decimal taxaJuros = 2,0m / 100;
                        int periodoAno= 3;*/

                    break;
                }


                case 4:
                {

                        Console.WriteLine("Vamos calcular o Rendimento de um investimento!");

                        Console.Write("Informe o Valor Presente: R$");
                        decimal vP4 = decimal.Parse(Console.ReadLine());

                        Console.Write("Informe a Taxa de Juros (insira o valor com vírgula): ");
                        decimal x4 = decimal.Parse(Console.ReadLine());
                        decimal tJ4 = x4 / 100;

                        Console.Write("Informe o Período Mensal: ");
                        int pM4 = int.Parse(Console.ReadLine());

                        Console.Write("Deseja realizar um saque durante o período (Digite 'sim' ou 'nao'): ");
                        string rS4 = Console.ReadLine().ToLower();

                        decimal vS4 = 0;
                        int mS4 = 0;

                        if (rS4 == "sim")
                        {
                            Console.Write("Em qual mês será realizado o saque: ");
                            mS4 = int.Parse(Console.ReadLine());

                            Console.Write("Qual será a quantia que deseja retirar da conta: R$");
                            vS4 = decimal.Parse(Console.ReadLine());
                        }

                        Console.WriteLine("===========================================================");

                        decimal vA4 = vP4;

                        for (int m4 = 1; m4 <= pM4; m4++)
                        {
                            decimal vF4 = vA4 * (1 + tJ4 * m4);

                            if (rS4 == "sim" && m4 == mS4)
                            {
                                vF4 -= vS4;
                                vA4 = vF4;
                                Console.WriteLine($"Saque de R${Math.Round(vS4, 2)} realizado no {m4}º mês");
                            }

                            Console.WriteLine($"Após o {m4}º mês, o valor acumulado será igual à: R${Math.Round(vF4, 2)}");
                        }

                        /*decimal valorPresente = 2000m;
                        decimal taxaJuros = 2,0m / 100;
                        int periodoAno= 6;*/


                      break;
                }

                case 5:
                {

                        Console.WriteLine("Vamos calcular o Rendimento de um investimento!");

                        Console.Write("Informe o Valor Futuro (VF): R$");
                        decimal vF5 = decimal.Parse(Console.ReadLine());

                        Console.Write("Informe o Período (em anos): ");
                        int pA5 = int.Parse(Console.ReadLine());
                        int pM5 = pA5 * 12;

                        Console.Write("Informe a Taxa de Juros (mensal, em %): ");
                        decimal tJ5 = decimal.Parse(Console.ReadLine()) / 100;

                        decimal vI5 = vF5 / (decimal)Math.Pow((1 + (double)tJ5), pM5);

                        Console.WriteLine($"O Valor Inicial (VP) necessário para alcançar R${vF5} em {pA5} anos será de R${Math.Round(vI5, 2)}.");

                        /*Valor Futuro: R$7.390,61
                        Periodo em anos: 2
                        Taxa de juros: 1,25*/

                    break;
                }

                default:
                {
                    break;
                }
            }
        }
    }
}
