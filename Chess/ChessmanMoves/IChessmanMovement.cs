using System.Collections.Generic;

namespace Chess
{
    public interface IChessmanMovement
    {
        List<ISquare> GetPossibleMoves(IChessman chessman, IChessTable chessTable);
        void ShowPossibleMoves(IChessman chessman, IChessTable chessTable);
    }
}