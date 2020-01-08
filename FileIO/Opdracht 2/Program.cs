﻿using System;
using System.Collections.Generic;
using System.IO;

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
            GalgjeSpel galgje = new GalgjeSpel();
            List<string> woorden;

            try
            {
                woorden = WoordenLijst();
            }
            catch
            {
                Console.WriteLine("Kon woorden.txt niet lezen");

                return;
            }

            galgje.Init(SelecteerWoord(woorden));

            if (SpeelGalgje(galgje))
            {
                Console.WriteLine("Je hebt gewonnen!");
            } else
            {
                Console.WriteLine("Je hebt verloren.");
            }

            Console.ReadKey();
        }

        List<string> WoordenLijst()
        {
            List<string> woorden = new List<string>();
            StreamReader reader = null;

            try
            {
                reader = new StreamReader("woorde.txt");

                while (!reader.EndOfStream)
                {
                    string woord = reader.ReadLine();

                    if (woord.Length >= 3)
                    {
                        woorden.Add(woord);
                    }
                }

                return woorden;
            }
            finally
            {
                reader.Close();
            }
        }

        string SelecteerWoord(List<string> woorden)
        {
            Random rnd = new Random();
            int index = rnd.Next(0, woorden.Count);

            return woorden[index];
        }

        bool SpeelGalgje(GalgjeSpel galgje)
        {
            List<char> ingevoerde_letters = new List<char>();
            int aantal_pogingen = 8;

            while (aantal_pogingen > 0 && !galgje.IsGeraden())
            {
                ToonWoord(galgje.geraden_woord);

                char letter = LeesLetter(ingevoerde_letters);

                ingevoerde_letters.Add(letter);

                if (!galgje.RaadLetter(letter))
                {
                    aantal_pogingen--;
                }

                Console.WriteLine("Aantal pogingen over: {0}", aantal_pogingen);
                Console.Write("Ingevoerde letters: ");

                ToonLetters(ingevoerde_letters);
            }

            return aantal_pogingen != 0;
        }

        void ToonWoord(string woord)
        {
            foreach (char letter in woord)
            {
                Console.Write("{0} ", letter);
            }

            Console.WriteLine();
        }

        void ToonLetters(List<char> letters)
        {
            foreach (char letter in letters)
            {
                Console.Write("{0} ", letter);
            }

            Console.WriteLine();
        }

        char LeesLetter(List<char> verbodenletters)
        {
            Console.Write("Geef een letter: ");
            char letter = Console.ReadLine()[0];

            while (verbodenletters.Contains(letter))
            {
                Console.Write("Geef een letter: ");
                letter = Console.ReadLine()[0];
            }

            return letter;
        }
    }
}
