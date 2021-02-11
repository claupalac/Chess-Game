using System.Collections.Generic;

namespace Chess
{
    public interface IChessmanMovement
    {
        List<ISquare> GetPossibleMoves(Chessman chessman, ChessTable chessTable);
    }
}