using System;

class Atividade1e2
{
    static void Main(string[] args)
    {
        Console.Write("Digite o número de linhas (X): ");
        int x = int.Parse(Console.ReadLine());

        Console.Write("Digite o número de colunas (Y): ");
        int y = int.Parse(Console.ReadLine());

        int[,] matriz = new int[x, y];
        Random random = new Random();

        // Preencher a matriz com valores aleatórios
        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < y; j++)
            {
                matriz[i, j] = random.Next(1, 101); // Valores aleatórios entre 1 e 100
            }
        }

        // Exibir a matriz
        Console.WriteLine("Matriz gerada:");
        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < y; j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }

        Console.WriteLine("Maior valor da matriz: " + EncontrarMaiorValor(matriz));
        Console.WriteLine("Menor valor da matriz: " + EncontrarMenorValor(matriz));
    }

    static int EncontrarMaiorValor(int[,] matriz)
    {
        int maior = matriz[0, 0];
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                if (matriz[i, j] > maior)
                {
                    maior = matriz[i, j];
                }
            }
        }
        return maior;
    }

    static int EncontrarMenorValor(int[,] matriz)
    {
        int menor = matriz[0, 0];
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                if (matriz[i, j] < menor)
                {
                    menor = matriz[i, j];
                }
            }
        }
        return menor;
    }
}
