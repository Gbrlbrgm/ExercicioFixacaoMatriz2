using System;

namespace Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Informe o número de linhas da matriz: ");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o número de colunas da matriz: ");
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(valores[j]);
                }
            }

            Console.WriteLine("Informe um número a ser buscado: ");
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i,j] == x)
                    {
                        Console.WriteLine("Posição: " + i + "," + j + ":");
                        if (j > 0)
                        {
                            Console.WriteLine("Esquerda: "+mat[i,j-1]);
                        }
                        if (i > 0)
                        {
                            Console.WriteLine("Cima: " + mat[i-1,j]);
                        }
                        if (j < n - 1) 
                        {
                            Console.WriteLine("Direita: "+mat[i,j+1]);
                        }
                        if (i < m - 1)
                        {
                            Console.WriteLine("Down: " + mat[i+1, j]);
                        }
                    }
                }
            }
        }
    }
}
