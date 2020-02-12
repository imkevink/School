using System;

namespace Opdracht_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program prog = new Program();

            prog.Start();

            Console.ReadKey();
        }

        void Start()
        {
            Team team = new Team();

            team.AddProgrammer(new Programmer("Peter", Specialty.CSharp));
            team.AddProgrammer(new Programmer("Kevin", Specialty.Java));
            team.AddProgrammer(new Programmer("John", Specialty.HTML));
            team.AddProgrammer(new Programmer("Susan", Specialty.PHP));
            team.AddProgrammer(new Programmer("Emma"));

            team.PrintAllMembers();
        }
    }
}
