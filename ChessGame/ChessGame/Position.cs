using System;

namespace ChessGame
{
    public class Position
    {
        public int row;
        public int col;

        public static Position Read(string question)
        {
            Console.Write(question);

            string input = Console.ReadLine();

            if (input[0] >= 'A' && input[0] <= 'F' && input[1] >= '1' && input[1] <= '8')
            {
                return new Position
                {
                    row = input[1] - '1',
                    col = input[0] - 'A',
                };
            } else
            {
                throw new Exception("Invalid position");
            }
        }
    }
}
