using System;

namespace ChessGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Program prog = new Program();
            prog.Start();
        }

        void Start()
        {
            ChessGame game = new ChessGame();

            game.Init();

            PlayChess(game);
        }

        void DisplayPiece(Piece piece)
        {
            if (piece == null) Console.Write("   ");
            else
            {
                if (piece.color == PieceColor.Black) Console.ForegroundColor = ConsoleColor.Black;
                else Console.ForegroundColor = ConsoleColor.White;

                string first_char = piece.type.ToString()[0].ToString();

                if (piece.type != PieceType.King && piece.type != PieceType.Queen)
                    first_char = first_char.ToLower();

                Console.Write(" {0} ", first_char);
            }
        }

        void DisplayBoard(Piece[,] board)
        {
            Console.Write("  ");

            for (int x = 0; x < board.GetLength(1); x++)
            {
                Console.Write(" {0} ", (char)('A' + x));
            }

            Console.WriteLine();

            for (int y = 0; y < board.GetLength(0); y++)
            {
                Console.Write("{0} ", y + 1);

                for (int x = 0; x < board.GetLength(1); x++)
                {
                    if ((y + x) % 2 == 0)
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                    else
                        Console.BackgroundColor = ConsoleColor.Gray;

                    DisplayPiece(board[y, x]);

                    Console.ResetColor();
                }

                Console.WriteLine();
            }
        }

        void PlayChess(ChessGame game)
        {
            while (true)
            {
                DisplayBoard(game.board);

                Position from;
                Position to;

                try
                {
                    from = Position.Read("From: ");
                    to = Position.Read("To: ");

                    game.CheckMove(from, to);
                }
                catch (Exception e)
                {
                    Console.Clear();
                    Console.WriteLine("{0}", e.Message);

                    continue;
                }

                game.DoMove(from, to);

                Console.Clear();
            }
        }
    }
}
