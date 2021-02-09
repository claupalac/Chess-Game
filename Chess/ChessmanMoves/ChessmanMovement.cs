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

        public abstract List<Square> GetPossibleMoves(Chessman chessman, ChessTable chessTable);

        public void ShowPossibleMoves(Chessman chessman, ChessTable chessTable)
        {
            foreach (Square aMove in GetPossibleMoves(chessman,chessTable))
            {
                aMove.ShowPosition();
            }
        }
    }
}