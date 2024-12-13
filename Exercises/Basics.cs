using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            decimal d = 1.33m; // utilizado para calculos financeiros (moeda) 
            double d2 = 1.33; // utilizado para calculos científicos e medições 
            float f = 1.33f; // engines de jogos como o unity devido a performance 

            /*int y = x + 2;
            int y = x - 2;
            int y = x * y;
            int y = x / y;*/

            string s = "Olá";

            s += " mundo!";

            int[] a = new int[] { 2, 5, 8 };

            int result = 0;
            foreach (int number in a)
            {
                result += number;
            }

            Test T = new Test();
            T.name = "Joao";
            string hello = T.SayHello();
            Test.abc;

            if (T.name == "Joao")
            {
                int abc = 1;    
                Console.WriteLine("Verdadeiro");
            }
            else if (T.name == "Pedro")
            {
                Console.WriteLine("Oi Pedro");
            }
            else
            {
                Console.WriteLine("Falso");
            }

            Console.WriteLine(y);
            Console.ReadKey();  
        }
    }

    class Test
    {
        public string name;
        public static string abc;

        public string SayHello()
        {
            return "Ola" + name;
        }
    }
}
