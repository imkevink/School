using System;
using System.IO;
using System.Collections.Generic;

namespace Opdracht_3
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
            Dictionary<string, string> words = ReadWords("words.txt");

            TranslateWords(words);
        }

        void TranslateWords(Dictionary<string, string> words)
        {
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();

            while (word != "stop")
            {
                if (word == "listall")
                {
                    ListAllWords(words);
                } else
                {
                    if (words.ContainsKey(word))
                    {
                        Console.WriteLine("{0} => {1}", word, words[word]);
                    } else
                    {
                        Console.WriteLine("Word '{0}' not found", word);
                    }
                }

                Console.Write("Enter a word: ");
                word = Console.ReadLine();
            }
        }

        void ListAllWords(Dictionary<string, string> words)
        {
            foreach (KeyValuePair<string, string> word in words)
            {
                Console.WriteLine("{0} => {1}", word.Key, word.Value);
            }
        }

        Dictionary<string, string> ReadWords(string path)
        {
            StreamReader reader = null;
            Dictionary<string, string> words = new Dictionary<string, string>();

            try
            {
                reader = new StreamReader(path);

                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] parts = line.Split(';');

                    words.Add(parts[0], parts[1]);
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("{0}", ex.Message);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }

            return words;
        }
    }
}
