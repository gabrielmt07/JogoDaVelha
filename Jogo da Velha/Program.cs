using System;
using jogo;

namespace Jogo_da_Velha
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] tab = new char[3, 3];
            char ch = ' ';
            char novamente = 's';

            while (novamente == 's' || novamente == 'S')
            {
                Console.Write("Selecione o jogador ('X' ou 'O'): ");
                ch = char.Parse(Console.ReadLine());
                ch = Tabuleiro.escolhendoJogador(ch);
                Console.Clear();

                while (Tabuleiro.terminado(tab, ch) == false)
                {
                    try
                    {
                        Tela.imprimirTela(tab);

                        Console.WriteLine("Vez do jogador '" + ch + "'");

                        Console.Write("Linha: ");
                        int linha = int.Parse(Console.ReadLine());
                        Tabuleiro.verificaPosicao(linha);

                        Console.Write("Coluna: ");
                        int coluna = int.Parse(Console.ReadLine());
                        Tabuleiro.verificaPosicao(coluna);

                        Tabuleiro.verificaJogada(tab, linha, coluna);
                        tab[linha, coluna] = ch;
                        Console.Clear();

                        ch = Tabuleiro.trocaJogador(ch);
                    }
                    catch (TabuleiroException e)
                    {
                        Console.WriteLine();
                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                        Console.Clear();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Jogada não permitida!");
                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                        Console.Clear();
                    }
                }
                Console.WriteLine();
                Console.WriteLine("Deseja jogar novamente? (s/n)");
                novamente = char.Parse(Console.ReadLine());
                tab = new char[3, 3];
                Console.Clear();
            }

            Console.WriteLine();
            Console.WriteLine("FIM DE JOGO!");
        }
    }
}
