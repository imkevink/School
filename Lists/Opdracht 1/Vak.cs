using System;

namespace Opdracht_1
{
    class Vak
    {
        public string naam;
        public int cijfer;
        public Beoordeling beoordeling;

        public bool IsBehaald()
        {
            return (beoordeling == Beoordeling.Voldoende ||
                beoordeling == Beoordeling.Goed) &&
                cijfer >= 55;
        }

        public bool IsCumLaude()
        {
            return beoordeling == Beoordeling.Goed && cijfer >= 80;
        }
    }

    enum Beoordeling
    {
        Geen,
        Absent,
        Onvoldoende,
        Voldoende,
        Goed,
    }
}
