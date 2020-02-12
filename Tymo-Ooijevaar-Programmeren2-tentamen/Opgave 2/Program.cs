using System;

namespace Opgave_2
{
    class Program
    {
        const int RIJ = 15;
        const int KOLOM = 20;
        const int MIN = 1;
        const int MAX = 200;

        static void Main(string[] args)
        {
            Program prog = new Program();

            prog.Start();
        }

        void Start()
        {
            int[,] matrix = new int[RIJ, KOLOM];

            VulMatrix(matrix);
            ToonMatrix(matrix);

            Positie kleinste = ZoekKleinste(matrix);
            Positie grootste = ZoekKGrootste(matrix);

            Console.WriteLine();

            ToonPositie("Kleinste", kleinste);
            ToonPositie("Grootste", grootste);

            Console.WriteLine();

            ToonMatrixPosities(matrix, grootste, kleinste);

            Console.ReadKey();
        }

        void VulMatrix(int[,] matrix)
        {
            Random rnd = new Random();

            for (int y = 0; y < RIJ; y++)
            {
                for (int x = 0; x < KOLOM; x++)
                {
                    matrix[y, x] = rnd.Next(MIN, MAX + 1);
                }
            }
        }

        void ToonMatrix(int[,] matrix)
        {
            for (int y = 0; y < RIJ; y++)
            {
                for (int x = 0; x < KOLOM; x++)
                {
                    Console.Write("{0,3} ", matrix[y, x]);
                }

                Console.WriteLine();
            }
        }

        void ToonPositie(string naam, Positie pos)
        {
            Console.WriteLine("{0}: {1} (rij: {2}, kolom: {3})", naam, pos.waarde, pos.rij, pos.kolom);
        }

        Positie ZoekKleinste(int[,] matrix)
        {
            Positie pos = new Positie
            {
                rij = 0,
                kolom = 0,
                waarde = MAX,
            };

            for (int y = 0; y < RIJ; y++)
            {
                for (int x = 0; x < KOLOM; x++)
                {
                    if (matrix[y, x] < pos.waarde)
                    {
                        pos.waarde = matrix[y, x];
                        pos.rij = y;
                        pos.kolom = x;
                    }
                }
            }

            return pos;
        }

        Positie ZoekKGrootste(int[,] matrix)
        {
            Positie pos = new Positie
            {
                rij = 0,
                kolom = 0,
                waarde = MIN,
            };

            for (int y = 0; y < RIJ; y++)
            {
                for (int x = 0; x < KOLOM; x++)
                {
                    if (matrix[y, x] > pos.waarde)
                    {
                        pos.waarde = matrix[y, x];
                        pos.rij = y;
                        pos.kolom = x;
                    }
                }
            }

            return pos;
        }

        void ToonMatrixPosities(int[,] matrix, Positie grootste, Positie kleinste)
        {
            for (int y = 0; y < RIJ; y++)
            {
                for (int x = 0; x < KOLOM; x++)
                {
                    if (y == kleinste.rij || x == kleinste.kolom) Console.BackgroundColor = ConsoleColor.DarkBlue;
                    if (y == grootste.rij || x == grootste.kolom) Console.ForegroundColor = ConsoleColor.Red;

                    if (matrix[y, x] == kleinste.waarde)
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    if (matrix[y, x] == grootste.waarde)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    Console.Write("{0,3} ", matrix[y, x]);
                    Console.ResetColor();
                }

                Console.WriteLine();
            }
        }
    }
}
