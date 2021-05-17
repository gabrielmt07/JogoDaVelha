using System;
using System.Collections.Generic;
using System.Text;
using jogo;

namespace jogo
{
    class Tabuleiro
    {

        public static bool terminado(char[,] mat, char ch)
        {
            if (mat[0, 0] == mat[0, 1] && mat[0, 1] == mat[0, 2] && mat[0, 2] != 0 ||
                mat[1, 0] == mat[1, 1] && mat[1, 1] == mat[1, 2] && mat[1, 2] != 0 ||
                mat[2, 0] == mat[2, 1] && mat[2, 1] == mat[2, 2] && mat[2, 2] != 0 ||

                mat[0, 0] == mat[1, 0] && mat[1, 0] == mat[2, 0] && mat[2, 0] != 0 ||
                mat[0, 1] == mat[1, 1] && mat[1, 1] == mat[2, 1] && mat[2, 1] != 0 ||
                mat[0, 2] == mat[1, 2] && mat[1, 2] == mat[2, 2] && mat[2, 2] != 0 ||

                mat[0, 0] == mat[1, 1] && mat[1, 1] == mat[2, 2] && mat[2, 2] != 0 ||
                mat[0, 2] == mat[1, 1] && mat[1, 1] == mat[2, 0] && mat[2, 0] != 0)
            {
                ch = trocaJogador(ch);
                Console.WriteLine($"Vitória do jogador '{ch}'");
                return true;
            }

            for (int i=0; i<3; i++)
            {
                for (int j=0; j<3; j++)
                {
                    if (mat[i, j] == 0)
                    {
                        return false;
                    }           
                }
            }
            Console.WriteLine("Empate!");
            return true;
        }

        public static char[,] limparTabuleiro(char[,] mat)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    mat[i, j] = ' ';
                }
            }
            return mat;
        }

        public static char trocaJogador(char ch)
        {
            if (ch == 'X')
            {
                return 'O';
            }
            else
            {
                return 'X';
            }
        }

        public static void verificaPosicao(int lin_col)
        {
            if (lin_col != 0 && lin_col != 1 && lin_col != 2)
            {
                throw new TabuleiroException("Posição inválida!");
            }
        }

        public static void verificaJogada(char[,] mat, int linha, int coluna)
        {
            if (mat[linha,coluna] != 0)
            {
                throw new TabuleiroException("Já existe uma peça nessa posição!");
            }
        }

        public static char escolhendoJogador(char ch)
        {
            while (ch != 'X' && ch != 'O')
            {
                Console.Write("Jogador não permitido! Escolha 'X' ou 'O': ");
                ch = char.Parse(Console.ReadLine());
            }
            return ch;
        }


    }
}
