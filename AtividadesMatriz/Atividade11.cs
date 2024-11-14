using System;

namespace AtividadesMatriz
{
    internal class Atividade11
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int N = 3; // Tamanho da matriz quadrada

            int[,] matriz = new int[N, N];

            // Preencher a matriz com números aleatórios de 1 a 100
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    matriz[i, j] = random.Next(1, 101);
                }
            }

            // Exibir a matriz gerada
            Console.WriteLine("Mapa do Tesouro (Quantidade de Moedas em Cada Região):");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }

            // Calcular a soma das moedas na diagonal principal
            int somaDiagonalPrincipal = 0;
            for (int i = 0; i < N; i++)
            {
                somaDiagonalPrincipal += matriz[i, i];
            }

            // Calcular a soma das moedas na diagonal secundária
            int somaDiagonalSecundaria = 0;
            for (int i = 0; i < N; i++)
            {
                somaDiagonalSecundaria += matriz[i, N - 1 - i];
            }

            // Exibir as somas das diagonais
            Console.WriteLine("Soma da Diagonal Principal: " + somaDiagonalPrincipal);
            Console.WriteLine("Soma da Diagonal Secundária: " + somaDiagonalSecundaria);

            // Indicar qual diagonal tem mais moedas de ouro
            if (somaDiagonalPrincipal > somaDiagonalSecundaria)
            {
                Console.WriteLine("O maior tesouro está na diagonal principal, vamos para lá!");
            }
            else if (somaDiagonalPrincipal < somaDiagonalSecundaria)
            {
                Console.WriteLine("O maior tesouro está na diagonal secundária, vamos para lá!");
            }
            else
            {
                Console.WriteLine("Ambas as diagonais têm a mesma quantidade de moedas de ouro!");
            }
        }
    }
}
