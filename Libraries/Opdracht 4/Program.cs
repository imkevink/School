using System;
using System.IO;
using System.Collections.Generic;

namespace Opdracht_4
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
            List<string> words = WoordenLijst();
            string lingoWord = SelecteerWoord(words);
            Console.WriteLine("{0}", lingoWord);
            LingoGame lingo = new LingoGame();
            lingo.Init(lingoWord);
            PlayLingo(lingo);

            Console.ReadKey();
        }

        void PlayLingo(LingoGame lingo)
        {
            int attemptsLeft = 5;

            while (attemptsLeft > 0 && !lingo.GuessedWord())
            {
                lingo.playerWord = ReadPlayerWord();
                lingo.CheckWord();
                DisplayResults(lingo);
                attemptsLeft--;
            }

            if (lingo.GuessedWord())
                Console.WriteLine("Je hebt het woord goed geraden!");
            else
                Console.WriteLine("Je heb het woord niet goed geraden, het woord was {0}.", lingo.lingoWord);
        }

        void DisplayResults(LingoGame lingo)
        {
            for (int i = 0; i < 5; i++)
            {
                if (lingo.letterResults[i] == LetterState.Correct)
                    Console.BackgroundColor = ConsoleColor.Green;
                else if (lingo.letterResults[i] == LetterState.WrongPosition)
                    Console.BackgroundColor = ConsoleColor.Yellow;

                Console.Write("{0}", lingo.playerWord[i]);
                Console.ResetColor();
            }

            Console.WriteLine();
        }

        string ReadPlayerWord()
        {
            string word;

            do
            {
                Console.Write("Raad een woord: ");
                word = Console.ReadLine();
            }
            while (word.Length != 5);

            return word;
        }

        List<string> WoordenLijst()
        {
            List<string> woorden = new List<string>();
            StreamReader reader = null;

            try
            {
                reader = new StreamReader("woorden.txt");

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

            while (woorden[index].Length != 5)
            {
                index = rnd.Next(0, woorden.Count);
            }

            return woorden[index];
        }
    }
}
