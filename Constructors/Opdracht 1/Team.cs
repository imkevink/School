using System.Collections.Generic;

namespace Opdracht_1
{
    class Team
    {
        private List<Programmer> programmers;

        public Team()
        {
            programmers = new List<Programmer>();
        }

        public void AddProgrammer(Programmer programmer)
        {
            programmers.Add(programmer);
        }

        public void PrintAllMembers()
        {
            foreach (Programmer programmer in programmers)
            {
                programmer.Print();
            }
        }
    }
}
