using System;
using System.Collections.Generic;

namespace AtividadesMatriz
{
    internal class Atividade8
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número de registros de raios:");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite as coordenadas dos raios (X Y):");

            // Cria um HashSet para armazenar as coordenadas dos raios
            HashSet<string> coordenadas = new HashSet<string>();
            bool raioRepetido = false;

            // Lê as coordenadas dos raios
            for (int i = 0; i < n; i++)
            {
                string[] entrada = Console.ReadLine().Split(' ');
                int x = int.Parse(entrada[0]);
                int y = int.Parse(entrada[1]);

                string coordenada = $"{x},{y}";

                // Verifica se a coordenada já foi registrada
                if (coordenadas.Contains(coordenada))
                {
                    raioRepetido = true;
                }
                else
                {
                    coordenadas.Add(coordenada);
                }
            }

            // Imprime o resultado
            if (raioRepetido)
            {
                Console.WriteLine(1);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
