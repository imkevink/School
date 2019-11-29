using System;
using System.Collections.Generic;

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
            List<Vak> rapport = LeesRapport(3);

            ToonRapport(rapport);

            Console.ReadKey();
        }

        List<Vak> LeesRapport(int aantalVakken)
        {
            List<Vak> rapport = new List<Vak>();

            for (int i = 0; i < aantalVakken; i++)
            {
                rapport.Add(LeesVak("Geef het vak: "));
            }

            return rapport;
        }

        void ToonRapport(List<Vak> rapport)
        {
            bool geslaagd = true;
            bool cum_laude = true;
            int aantal_herkansingen = 0;

            foreach (Vak vak in rapport)
            {
                Console.WriteLine("{0} : {1} {2}", vak.naam, vak.cijfer, vak.beoordeling);

                if (!vak.IsBehaald())
                {
                    geslaagd = false;
                    aantal_herkansingen++;
                }

                if (!vak.IsCumLaude())
                {
                    cum_laude = false;
                }
            }

            if (geslaagd)
            {
                if (cum_laude)
                {
                    Console.WriteLine("Je bent cum laude geslaagd.");
                } else
                {
                    Console.WriteLine("Je bent geslaagd.");
                }
            } else
            {
                Console.WriteLine("Je bent gezakt en hebt {0} herkansingen.", aantal_herkansingen);
            }
        }

        Beoordeling LeesBeoordeling(string vraag)
        {
            while (true)
            {
                string antwoord = LeesString(vraag);

                switch (antwoord.ToLower())
                {
                    case "geen":
                        return Beoordeling.Geen;
                    case "absent":
                        return Beoordeling.Absent;
                    case "onvoldoende":
                        return Beoordeling.Onvoldoende;
                    case "voldoende":
                        return Beoordeling.Voldoende;
                    case "goed":
                        return Beoordeling.Goed;
                    default:
                        Console.WriteLine("{0} is geen geldige beoordeling.", antwoord);
                        break;
                }
            }
        }

        void ToonBeoordeling(Beoordeling beoordeling)
        {
            Console.WriteLine(beoordeling);
        }

        Vak LeesVak(string vraag)
        {
            string naam = LeesString(vraag);
            int cijfer = LeesInt("Geef het cijfer: ", 1, 100);
            Beoordeling beoordeling = LeesBeoordeling("Geef de beoordeling: ");
            Vak vak = new Vak
            {
                naam = naam,
                cijfer = cijfer,
                beoordeling = beoordeling
            };

            return vak;
        }

        void ToonVak(Vak vak)
        {
            Console.WriteLine("Vak: {0}", vak.naam);
            Console.WriteLine("Cijfer: {0}", vak.cijfer);
            Console.Write("Beoordeling: ");
            ToonBeoordeling(vak.beoordeling);
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
