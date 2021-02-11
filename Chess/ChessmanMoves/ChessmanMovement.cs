using System;
using System.Collections.Generic;

namespace Chess
{
    public abstract class ChessmanMovement : IChessmanMovement
    {
        protected List<IBasicMove> _myMoves;

        public ChessmanMovement()
        {
            this._myMoves = new List<IBasicMove>();
        }

        public abstract List<ISquare> GetPossibleMoves(IChessman chessman, IChessTable chessTable);

        public void ShowPossibleMoves(IChessman chessman, IChessTable chessTable)
        {
            foreach (ISquare aMove in GetPossibleMoves(chessman,chessTable))
            {
                Console.WriteLine(aMove.ShowPosition());
            }
        }
    }
}