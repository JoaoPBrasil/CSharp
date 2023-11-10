using System;
using System.Collections.Generic;


namespace Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nomes = new List<string>()
            {
                "Thiago",
                "Joao",
                "Maria",
                "Ana",
                "Marcia",
                "Daniel",
                "Eric",
                "Amanda"
            };
            List<string> nomes2 = new List<string>()
            {
                "Anderson",
                "Juliana",
                "Giovanni"
            };
            nomes.Insert(5, "Luciana");
            nomes.Add("Cleber");
            nomes.InsertRange(nomes.Count, nomes2);
            string retorno = nomes.Find(x => x.StartsWith('A'));
            retorno = nomes.FindLast(x => x.StartsWith('A'));
            List<string> nomesComM = nomes.FindAll(x => x.StartsWith('M'));

            for(int i = 0; i < nomes.Count; i++)
            {
                Console.WriteLine(nomes[i]);
            }

            Console.WriteLine(new string('=', 100));
            nomes.Remove("Eric");
            nomes.RemoveAt(5);
            nomes.RemoveAll(x => x.StartsWith('A'));
            nomes.Sort();
            nomes.RemoveRange(2, nomes.Count - 3);
            string[] novo = new string[10];
            nomes.CopyTo(novo);
            for (int i = 0; i < nomes.Count; i++)
            {
                Console.WriteLine(nomes[i]);
            }

            Console.WriteLine("Ultimo nome com A: " + retorno);
            Console.WriteLine("index do ultimo nome: " + nomes.FindIndex(x => x.Equals(retorno)));
            Console.WriteLine("Last index de nome que começa com A: " + nomes.FindLastIndex(x => x.StartsWith('J')));
            Console.WriteLine();
        }

    }
}
