using System.Collections.Generic;

namespace Chess
{
    public interface IChessmanMovement
    {
        List<IPosition> GetPossibleMoves(IPosition oPosition, IChessTable chessTable);
    }
}