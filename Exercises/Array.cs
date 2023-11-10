using System;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] nomes = new string[10];
            nomes[0] = "João";
            nomes[1] = "Francisco";
            nomes[2] = "José";
            nomes[3] = "Danilo";
            nomes[4] = "Luciana";
            nomes[4] = "Emeverson";
            nomes[5] = "Eri";
            nomes[6] = "Vitoria";

            printaNome(nomes);
            InsereNomeEmPosicao(4, "Luciana", nomes);
            printaNome(nomes);
            InsereNomeEmPosicao(0, "Tiago", nomes);
            printaNome(nomes);
            InsereNomeEmPosicao(5, "Cleber", nomes);
            InsereNomeEmPosicao(2, "Rebeca", nomes);
            printaNome(nomes);

        }

        public static void InsereNomeEmPosicao(int posicao, string nome, string[] nomes)
        {
            for (int i = 0; i < nomes.Length; i++)
            {
                if (i == posicao)
                {
                    if (validaPosicaoVazia(nomes))
                    {
                        for (int j = 9; j > 0; j--)
                        {
                            int posicaoVetor = j - 1;
                            nomes[j] = nomes[posicaoVetor];
                        }
                        nomes[posicao] = nome;
                    }
                    else
                    {
                        int num = nomes.Length * 2;
                        string[] novosNomes = new string[num];
                        for (int k = 0; k < nomes.Length; k++)
                        {
                            novosNomes[k] = nomes[k];
                        }
                        InsereNomeEmPosicao(posicao, nome, novosNomes);
                        nomes = novosNomes;
                    }
                }
            }
        }

        static bool validaPosicaoVazia(string[] nomes)
        {
            for (int i = 0; i < nomes.Length; i++)
            {
                if (nomes[i] == null)
                {
                    return true;
                }
                else
                {
                    continue;
                }
            }
            return false;
        }

        static void printaNome(string[] nomes)
        {
            for (int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine($"Posição : {i} Nome {nomes[i]}");
            }

            Console.WriteLine(new string('=', 100));
        }


    }
}
