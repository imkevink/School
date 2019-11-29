using System;

namespace Opdracht_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program prog = new Program();
            prog.Start();
        }

        void Start()
        {
            int[,] matrix = new int[11, 11];

            InitMatrixLinear(matrix);
            PrintMatrixWithCross(matrix);

            Console.ReadKey();
        }

        void InitMatrix(int[,] matrix)
        {
            for (int y = 0; y < matrix.GetLength(0); y++)
            {
                for (int x = 0; x < matrix.GetLength(1); x++)
                {
                    matrix[y, x] = y * matrix.GetLength(1) + x + 1;
                }
            }
        }

        void InitMatrixLinear(int[,] matrix)
        {
            int width = matrix.GetLength(1);

            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i / width, i % width] = i + 1;
            }
        }

        void PrintMatrix(int[,] matrix)
        {
            for (int y = 0; y < matrix.GetLength(0); y++)
            {
                for (int x = 0; x < matrix.GetLength(1); x++)
                {
                    Console.Write("{0,3} ", matrix[y, x]);
                }

                Console.WriteLine();
            }
        }

        void PrintMatrixWithCross(int[,] matrix)
        {
            for (int y = 0; y < matrix.GetLength(0); y++)
            {
                for (int x = 0; x < matrix.GetLength(1); x++)
                {
                    if (x == matrix.GetLength(1) - 1 - y)
                    {
                        Console.BackgroundColor = ConsoleColor.Yellow;
                    }

                    if (x == y)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }

                    Console.Write("{0,3} ", matrix[y, x]);
                    Console.ResetColor();
                }

                Console.WriteLine();
            }
        }

        int LeesInt(string vraag)
        {
            Console.Write(vraag);

            return int.Parse(Console.ReadLine());
        }

        int LeesInt(string vraag, int min, int max)
        {
            int getal = LeesInt(vraag);

            if (getal >= min && getal <= max)
            {
                return getal;
            }
            else
            {
                Console.WriteLine($"Number is not in the range: {min}..{max}.");

                return LeesInt(vraag, min, max);
            }
        }

        string LeesString(string vraag)
        {
            Console.Write(vraag);

            return Console.ReadLine();
        }
    }
}
