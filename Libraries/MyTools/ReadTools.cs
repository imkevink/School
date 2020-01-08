using System;

namespace MyTools
{
    public class ReadTools
    {
        public static int ReadInt(string vraag)
        {
            Console.Write(vraag);

            int value;

            while (!int.TryParse(Console.ReadLine(), out value))
                Console.Write(vraag);

            return value;
        }

        public static int ReadInt(string vraag, int min, int max)
        {
            int getal = ReadInt(vraag);

            if (getal >= min && getal <= max)
            {
                return getal;
            }
            else
            {
                Console.WriteLine($"Number is not in the range: {min}..{max}.");

                return ReadInt(vraag, min, max);
            }
        }

        public static string ReadString(string vraag)
        {
            Console.Write(vraag);

            return Console.ReadLine();
        }
    }
}
