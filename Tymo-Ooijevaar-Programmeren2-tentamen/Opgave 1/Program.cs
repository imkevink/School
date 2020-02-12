using System;

namespace Opgave_1
{
    class Program
    {
        public const string ALFABET = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ.,?!;:-'\" ";

        static void Main(string[] args)
        {
            Program prog = new Program();

            prog.Start();
        }

        void Start()
        {
            Console.Write("Geef het bericht: ");

            string bericht = Console.ReadLine();
            string sleutel = MaakGeheimeSleutel(bericht.Length);

            Console.WriteLine("Geheime sleutel: {0}", sleutel);

            try
            {
                string versleuteld = OneTimePad(bericht, sleutel);

                Console.WriteLine("Versleuteld bericht: {0}", versleuteld);
            }
            catch (Exception e)
            {
                Console.WriteLine("Fout opgetreden tijdens versleutelen: {0}.", e.Message);
            }
            
            Console.ReadKey();
        }

        string MaakGeheimeSleutel(int lengte)
        {
            string sleutel = "";
            Random rnd = new Random();

            for (int i = 0; i < lengte; i++)
            {
                int index = rnd.Next(0, ALFABET.Length);

                sleutel += ALFABET[index];
            }

            return sleutel;
        }

        string OneTimePad(string bericht, string sleutel)
        {
            string resultaat = "";

            for (int i = 0; i < bericht.Length; i++)
            {
                int bericht_index = ALFABET.IndexOf(bericht[i]);

                if (bericht_index < 0) throw new Exception($"Karakter '{bericht[i]}' kan niet worden versleuteld");

                int sleutel_index = ALFABET.IndexOf(sleutel[i]);
                int index = (bericht_index + sleutel_index) % ALFABET.Length;

                resultaat += ALFABET[index];
            }

            return resultaat;
        }
    }
}
