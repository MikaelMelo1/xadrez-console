using System;
using tabuleiro;
using xadrez;

namespace xadrez
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PartidadeXadrez partida = new PartidadeXadrez();

                while (!partida.terminada)
                {
                    try
                    {
                        Console.Clear();
                        Tela.imprimirTabuleiro(partida.tab);
                        Console.WriteLine();
                        Console.WriteLine("Turno: " + partida.turno);
                        Console.WriteLine("Aguardando jogada: " + partida.jogadorAtual);

                        Console.Write("Origem: ");
                        Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                        partida.validarPosicaoDeOrigem(origem);

                        bool[,] posicoesPossiveis = partida.tab.peca(origem).movimentosPossiveis();

                        Console.Clear();
                        Tela.imprimirTabuleiro(partida.tab, posicoesPossiveis);
                        Console.WriteLine();

                        Console.Write("Destino: ");
                        Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

                        partida.validarPosicaoDeDestino(origem, destino);
                        partida.realizaJogada(origem, destino, partida.jogadorAtual);
                    }
                    catch (TabuleiroException e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadLine(); // pausa para o usuário ler o erro
                    }
                }
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
