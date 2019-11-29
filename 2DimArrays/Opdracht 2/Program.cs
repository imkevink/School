using System;

namespace Opdracht_2
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

            InitMatrixRandom(matrix, 1, 100);
            PrintMatrix(matrix);

            int zoekGetal = LeesInt("Geef een zoekgetal: ");
            Positie firstPos = ZoekGetal(matrix, zoekGetal);
            Positie lastPos = ZoekGetalAchterwaards(matrix, zoekGetal);

            Console.WriteLine("Zoekgetal {0} komt het eerst voor op positie [{1}, {2}]", zoekGetal, firstPos.rij, firstPos.kolom);
            Console.WriteLine("Zoekgetal {0} komt het laatst voor op positie [{1}, {2}]", zoekGetal, lastPos.rij, lastPos.kolom);

            Console.ReadKey();
        }

        void InitMatrixRandom(int[,] matrix, int min, int max)
        {
            Random rnd = new Random();

            for (int y = 0; y < matrix.GetLength(0); y++)
            {
                for (int x = 0; x < matrix.GetLength(1); x++)
                {
                    matrix[y, x] = rnd.Next(min, max);
                }
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

        Positie ZoekGetal(int[,] matrix, int zoekGetal)
        {
            Positie pos = new Positie();

            for (int y = 0; y < matrix.GetLength(0); y++)
            {
                for (int x = 0; x < matrix.GetLength(1); x++)
                {
                    if (matrix[y, x] == zoekGetal)
                    {
                        pos.rij = y;
                        pos.kolom = x;

                        return pos;
                    }
                }
            }

            return pos;
        }

        Positie ZoekGetalAchterwaards(int[,] matrix, int zoekGetal)
        {
            Positie pos = new Positie();

            for (int y = matrix.GetLength(0) - 1; y >= 0; y--)
            {
                for (int x = matrix.GetLength(1) - 1; x >= 0; x--)
                {
                    if (matrix[y, x] == zoekGetal)
                    {
                        pos.rij = y;
                        pos.kolom = x;

                        return pos;
                    }
                }
            }

            return pos;
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
