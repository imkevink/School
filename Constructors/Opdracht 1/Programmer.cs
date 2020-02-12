using System;

namespace Opdracht_1
{
    class Programmer
    {
        public string name;
        public Specialty specialty;

        public Programmer(string name)
            : this(name, Specialty.Unknown)
        { }

        public Programmer(string name, Specialty specialty)
        {
            this.name = name;
            this.specialty = specialty;
        }

        public void Print()
        {
            Console.WriteLine("Naam: {0}, Specialty: {1}", name, specialty);
        }
    }
}
