using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa("Joao", "Email@gmail.com", "22 22222-2222");
            Pessoa p2 = new Pessoa();
            p1.exibeDados();
            Console.ReadKey();            
        }
    }
}
