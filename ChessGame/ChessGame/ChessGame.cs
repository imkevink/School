using System;

namespace ChessGame
{
    public class ChessGame
    {
        public Piece[,] board = new Piece[8, 8];

        public void Init()
        {
            InitBoard();
            PutPieces();
        }

        void InitBoard()
        {
            for (int y = 0; y < board.GetLength(0); y++)
            {
                for (int x = 0; x < board.GetLength(1); x++)
                {
                    board[y, x] = null;
                }
            }
        }

        void PutPieces()
        {
            PieceType[] order = { PieceType.Rook, PieceType.Knight, PieceType.Bishop, PieceType.King,
                                  PieceType.Queen, PieceType.Bishop, PieceType.Knight, PieceType.Rook };

            for (int x = 0; x < board.GetLength(1); x++)
            {
                board[0, x] = new Piece { type = order[x], color = PieceColor.White };
                board[1, x] = new Piece { type = PieceType.Pawn, color = PieceColor.White };
                board[6, x] = new Piece { type = PieceType.Pawn, color = PieceColor.Black };
                board[7, x] = new Piece { type = order[x], color = PieceColor.Black };
            }
        }

        public void CheckMove(Position from, Position to)
        {
            if (board[from.row, from.col] == null)
                throw new Exception("The from position does not contain a piece.");

            if (board[to.row, to.col] != null)
                throw new Exception("The to position already contains a piece.");

            if (!ValidMove(board[from.row, from.col], from, to))
                throw new Exception("Invalid move");
        }

        public bool ValidMove(Piece piece, Position from, Position to)
        {
            int dx = Math.Abs(to.col - from.col);
            int dy = Math.Abs(to.row - from.row);

            if (dx == 0 && dy == 0)
                return false;

            switch (piece.type)
            {
                case PieceType.Pawn:
                    return dx == 0 && dy == 1;
                case PieceType.Rook:
                    return dx * dy == 0;
                case PieceType.Knight:
                    return dx * dy == 2;
                case PieceType.Bishop:
                    return dx == dy;
                case PieceType.King:
                    return dx == 1 || dy == 1;
                case PieceType.Queen:
                    return dx * dy == 0 || dx == dy;
                default:
                    return false;
            }
        }

        public void DoMove(Position from, Position to)
        {
            board[to.row, to.col] = board[from.row, from.col];
            board[from.row, from.col] = null;
        }
    }
}
