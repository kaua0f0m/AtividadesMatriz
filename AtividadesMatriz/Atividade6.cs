using System;

namespace AtividadesMatriz
{
    internal class Atividade6
    {
        public static int[,] SomarMatrizes(int[,] matriz1, int[,] matriz2)
        {
            int linhas1 = matriz1.GetLength(0);
            int colunas1 = matriz1.GetLength(1);
            int linhas2 = matriz2.GetLength(0);
            int colunas2 = matriz2.GetLength(1);

            if (linhas1 != linhas2 || colunas1 != colunas2)
            {
                throw new ArgumentException("As matrizes devem ser de mesma ordem para serem somadas.");
            }

            int[,] soma = new int[linhas1, colunas1];

            for (int i = 0; i < linhas1; i++)
            {
                for (int j = 0; j < colunas1; j++)
                {
                    soma[i, j] = matriz1[i, j] + matriz2[i, j];
                }
            }

            return soma;
        }

        public static void MostrarMatriz(int[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            int[,] matriz1 = {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            int[,] matriz2 = {
                { 9, 8, 7 },
                { 6, 5, 4 },
                { 3, 2, 1 }
            };

            Console.WriteLine("Matriz 1:");
            MostrarMatriz(matriz1);

            Console.WriteLine("Matriz 2:");
            MostrarMatriz(matriz2);

            try
            {
                int[,] soma = SomarMatrizes(matriz1, matriz2);
                Console.WriteLine("Soma das Matrizes:");
                MostrarMatriz(soma);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
