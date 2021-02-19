using System;
using System.Collections.Generic;

namespace Chess
{
    public abstract class ChessmanMovement : IChessmanMovement
    {
        protected List<IMove> moves;
        public ChessmanMovement()
        {
            moves = new List<IMove>();
        }
        public abstract List<IPosition> GetPossibleMoves(IPosition oPosition, IChessTable chessTable);
    }
}