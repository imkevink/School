namespace CandyCrushLogics
{
    public class CandyCrusher
    {
        public static bool ScoreRijAanwezig(RegularCandies[,] candies)
        {
            for (int y = 0; y < candies.GetLength(0); y++)
            {
                RegularCandies candy = candies[y, 0];
                int aantal = 0;

                for (int x = 0; x < candies.GetLength(1); x++)
                {
                    if (candies[y, x] == candy)
                    {
                        aantal++;
                    }
                    else
                    {
                        candy = candies[y, x];
                        aantal = 1;
                    }

                    if (aantal == 3)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public static bool ScoreKolomAanwezig(RegularCandies[,] candies)
        {
            for (int x = 0; x < candies.GetLength(1); x++)
            {
                RegularCandies candy = candies[0, x];
                int count = 0;

                for (int y = 0; y < candies.GetLength(0); y++)
                {
                    if (candies[y, x] == candy)
                    {
                        count++;
                    }
                    else
                    {
                        candy = candies[y, x];
                        count = 1;
                    }

                    if (count == 3)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
