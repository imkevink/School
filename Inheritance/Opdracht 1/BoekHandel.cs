using System;
using System.Collections.Generic;

namespace Opdracht_1
{
    class BoekHandel
    {
        private List<Boek> voorraad = new List<Boek>();

        public void VoegToe(Boek boek)
        {
            voorraad.Add(boek);
        }

        public void VoegToe(Tijdschrift tijdscrift)
        {
            voorraad.Add(tijdscrift);
        }

        public void PrintVoorraad()
        {
            double totaal = 0;

            foreach (Boek boek in voorraad)
            {
                boek.Print();
                totaal += boek.prijs;
            }

            Console.WriteLine("Total sales price: {0}", totaal.ToString("0.00"));
        }
    }
}
