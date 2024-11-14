using System;

namespace AtividadesMatriz
{
    internal class Atividade3
    {
        public static int ContarOcorrencias(int[,] matriz, int x)
        {
            int contador = 0;
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (matriz[i, j] == x)
                    {
                        contador++;
                    }
                }
            }
            return contador;
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
            int[,] matriz = {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 },
                { 1, 2, 3 }
            };

            Console.WriteLine("Informe o número a ser contado na matriz:");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Matriz:");
            MostrarMatriz(matriz);

            int ocorrencias = ContarOcorrencias(matriz, x);
            Console.WriteLine($"O número {x} aparece {ocorrencias} vezes na matriz.");
        }
    }
}
