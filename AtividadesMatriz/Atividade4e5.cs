using System;

namespace AtividadesMatriz
{
    internal class Atividade4e5
    {
        public static void MostrarDiagonalPrincipal(int[,] matriz)
        {
            Console.WriteLine("Diagonal Principal:");
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                Console.Write(matriz[i, i] + "\t");
            }
            Console.WriteLine();
        }

        public static void MostrarDiagonalSecundaria(int[,] matriz)
        {
            Console.WriteLine("Diagonal Secundária:");
            int n = matriz.GetLength(0);
            for (int i = 0; i < n; i++)
            {
                Console.Write(matriz[i, n - 1 - i] + "\t");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Informe a ordem da matriz (N x N), máximo 100:");
            int n = int.Parse(Console.ReadLine());

            if (n > 100)
            {
                Console.WriteLine("A ordem da matriz não pode ser maior que 100.");
                return;
            }

            int[,] matriz = new int[n, n];
            Random random = new Random();

            // Preenchendo a matriz com valores aleatórios
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = random.Next(1, 101); // Valores entre 1 e 100
                }
            }

            Console.WriteLine("Matriz:");
            MostrarMatriz(matriz);

            MostrarDiagonalPrincipal(matriz);
            MostrarDiagonalSecundaria(matriz);
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
    }
}
