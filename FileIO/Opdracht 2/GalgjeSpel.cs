using System.Text;

namespace Opdracht_2
{
    public class GalgjeSpel
    {
        public string geheim_woord;
        public string geraden_woord;

        public void Init(string geheim_woord)
        {
            this.geheim_woord = geheim_woord;
            geraden_woord = "".PadLeft(geheim_woord.Length, '.');
        }

        public bool RaadLetter(char letter)
        {
            if (geheim_woord.Contains(letter.ToString()))
            {
                StringBuilder sb = new StringBuilder(geraden_woord);

                for (int i = 0; i < geraden_woord.Length; i++)
                {
                    if (geheim_woord[i] == letter)
                    {
                        sb[i] = letter;
                    }
                }

                geraden_woord = sb.ToString();

                return true;
            } else
            {
                return false;
            }
        }

        public bool IsGeraden()
        {
            return geheim_woord == geraden_woord;
        }
    }
}
