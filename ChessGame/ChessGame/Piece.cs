using System;

namespace ChessGame
{
    public class Piece
    {
        public PieceColor color;
        public PieceType type;
    }

    public enum PieceColor
    {
        Black,
        White,
    }

    public enum PieceType
    {
        Pawn,
        Rook,
        Knight,
        Bishop,
        King,
        Queen,
    }
}
