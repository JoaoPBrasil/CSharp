using System;
using System.Globalization;

namespace Aula4_Operadores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o seu nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Informe quantos quartos tem sua casa: ");
            int qtos = int.Parse (Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto: ");
            double preco = (double.Parse(Console.ReadLine()));
            Console.WriteLine("Informe seu último nome, sua idade e sua altura: ");
            string dados = Console.ReadLine();
            string[] dadosVet = dados.Split(" ");
            Console.WriteLine(nome);
            Console.WriteLine(qtos);
            Console.WriteLine(preco.ToString("C", CultureInfo.GetCultureInfo("pt-BR")));
            Console.WriteLine(dadosVet [0]);
            Console.WriteLine(dadosVet [1]);
            Console.WriteLine(dadosVet [2]);
        }
    }
}
