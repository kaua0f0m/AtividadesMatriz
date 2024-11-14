using System;

namespace AtividadesMatriz
{
    internal class Atividade7
    {
        public static double[,] SomarMatrizes(double[,] matriz1, double[,] matriz2)
        {
            int linhas = matriz1.GetLength(0);
            int colunas = matriz1.GetLength(1);
            double[,] soma = new double[linhas, colunas];

            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    soma[i, j] = matriz1[i, j] + matriz2[i, j];
                }
            }

            return soma;
        }

        public static double[,] SubtrairMatrizes(double[,] matriz1, double[,] matriz2)
        {
            int linhas = matriz1.GetLength(0);
            int colunas = matriz1.GetLength(1);
            double[,] subtracao = new double[linhas, colunas];

            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    subtracao[i, j] = matriz2[i, j] - matriz1[i, j];
                }
            }

            return subtracao;
        }

        public static void AdicionarConstante(double[,] matriz, double constante)
        {
            int linhas = matriz.GetLength(0);
            int colunas = matriz.GetLength(1);

            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    matriz[i, j] += constante;
                }
            }
        }

        public static void MostrarMatriz(double[,] matriz)
        {
            int linhas = matriz.GetLength(0);
            int colunas = matriz.GetLength(1);

            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Informe o número de linhas da matriz:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o número de colunas da matriz:");
            int m = int.Parse(Console.ReadLine());

            double[,] matriz1 = new double[n, m];
            double[,] matriz2 = new double[n, m];
            Random random = new Random();

            // Preenchendo as matrizes com valores aleatórios
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matriz1[i, j] = random.NextDouble() * 100;
                    matriz2[i, j] = random.NextDouble() * 100;
                }
            }

            while (true)
            {
                Console.WriteLine("Menu de Opções:");
                Console.WriteLine("(a) Somar as duas matrizes");
                Console.WriteLine("(b) Subtrair a primeira matriz da segunda");
                Console.WriteLine("(c) Adicionar uma constante às duas matrizes");
                Console.WriteLine("(d) Imprimir as matrizes");
                Console.WriteLine("(e) Sair");
                char opcao = Console.ReadLine()[0];

                switch (opcao)
                {
                    case 'a':
                        double[,] soma = SomarMatrizes(matriz1, matriz2);
                        Console.WriteLine("Soma das Matrizes:");
                        MostrarMatriz(soma);
                        break;
                    case 'b':
                        double[,] subtracao = SubtrairMatrizes(matriz1, matriz2);
                        Console.WriteLine("Subtração da Primeira Matriz da Segunda:");
                        MostrarMatriz(subtracao);
                        break;
                    case 'c':
                        Console.WriteLine("Informe a constante a ser adicionada:");
                        double constante = double.Parse(Console.ReadLine());
                        AdicionarConstante(matriz1, constante);
                        AdicionarConstante(matriz2, constante);
                        Console.WriteLine("Constante adicionada às matrizes.");
                        break;
                    case 'd':
                        Console.WriteLine("Matriz 1:");
                        MostrarMatriz(matriz1);
                        Console.WriteLine("Matriz 2:");
                        MostrarMatriz(matriz2);
                        break;
                    case 'e':
                        return;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
        }
    }
}
