using System;

namespace AtividadesMatriz
{
    class Atividade10
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int R = 3; // Número de regiões
            int C = 3; // Número de cidades por região

            int[,] matriz = new int[R, C];

            // Preencher a matriz com números aleatórios de 0 a 100
            for (int i = 0; i < R; i++)
            {
                for (int j = 0; j < C; j++)
                {
                    matriz[i,j] = random.Next(0, 101);
                }
            }

            // Exibir a matriz gerada
            Console.WriteLine("Matriz das Tropas (Quantidade de Tropas por Cidade):");
            for (int i = 0; i < R; i++)
            {
                Console.Write("Região " + (i + 1) + ": ");
                for (int j = 0; j < C; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }

            // Calcular e exibir a soma total das tropas de cada região
            Console.WriteLine("Força Total das Regiões:");
            for (int i = 0; i < R; i++)
            {
                int soma = 0;
                for (int j = 0; j < C; j++)
                {
                    soma += matriz[i, j];
                }
                Console.WriteLine("Região " + (i + 1) + ": " + soma + " tropas");
            }
        }
    }
}
