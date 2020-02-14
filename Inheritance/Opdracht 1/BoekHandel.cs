using System;
using System.Collections.Generic;

namespace Opdracht_1
{
    class BoekHandel
    {
        private List<BoekItem> voorraad = new List<BoekItem>();

        public void VoegToe(BoekItem boek)
        {
            voorraad.Add(boek);
        }

        public void PrintVoorraad()
        {
            double totaal = 0;

            foreach (BoekItem item in voorraad)
            {
                item.Print();
                totaal += item.prijs;
            }

            Console.WriteLine("Total sales price: {0}", totaal.ToString("0.00"));
        }
    }
}
