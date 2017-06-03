using System;

namespace MatrixExpander
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int multiplier = 0;
            Console.Write("N: ");
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Please enter a number.");
            }
            int[,] matrix = new int[n, n];
            Console.Write("Multiplier: ");
            while (!int.TryParse(Console.ReadLine(), out multiplier))
            {
                Console.WriteLine("Please enter a number.");
            }
            int newN = n * multiplier;
            int[,] newMatrix = new int[newN, newN];
            Console.WriteLine("\nInput: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("Matrix[" + i + "][" + j + "]: ");
                    while (!int.TryParse(Console.ReadLine(), out matrix[i, j]))
                    {
                        Console.WriteLine("Please enter a number.");
                    }
                }
            }
            newMatrix = MatrixOperations.Expand(multiplier, matrix);
            Console.WriteLine("\nResult:");
            for (int i = 0; i < newN; i++)
            {
                for (int j = 0; j < newN; j++)
                {
                    Console.Write(newMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
