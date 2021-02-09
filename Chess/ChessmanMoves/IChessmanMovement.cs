using System.Collections.Generic;

namespace Chess
{
    public interface IChessmanMovement
    {
        List<Square> GetPossibleMoves(Chessman chessman, ChessTable chessTable);
    }
}