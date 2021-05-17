using System;
using jogo;

namespace jogo
{
    class Tela
    {

        public static void imprimirTela(char[,] tab)
        {
            Console.Write("  0 1 2");
            for (int i=0; i<3; i++)
            {
                Console.WriteLine();
                Console.Write(i + " ");
                for (int j=0; j<3; j++)
                {
                    if (tab[i,j] == 0)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write(tab[i, j] + " ");
                    }

                }
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
