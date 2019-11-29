namespace Opdracht_2
{
    struct Persoon
    {
        public string Voornaam;
        public string Achternaam;
        public int Leeftijd;
        public string Woonplaats;
        public GeslachtType Geslacht;
    }

    enum GeslachtType
    {
        Man,
        Vrouw,
    }
}
