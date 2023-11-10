using System;

namespace Atividade_06_01
{
    class Program 
    {
        static void Main(string[] args)
        {
            Funcionario F1;
            Funcionario F2;
            F1 = new Funcionario();
            F2 = new Funcionario();
            Console.WriteLine("Informe o nome e o salario do primeiro funcionario.");
            F1.Nome = Console.ReadLine();
            F1.Salario = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o nome e a idade da segunda pessoa.");
            F2.Nome = Console.ReadLine();
            F2.Salario = int.Parse(Console.ReadLine());

            float media;
            media = (F1.Salario + F2.Salario) / 2;

            Console.WriteLine(media + "é a media dos salários");

        }

    }
}
