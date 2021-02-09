using System.Collections.Generic;

namespace Chess
{
    public class KingMovement : ChessmanMovement
    {
        //private const int Range = 1;
        public KingMovement()
        {
            _myMoves.Add( new MoveForward());
            _myMoves.Add(new MoveBackward());
            _myMoves.Add(new MoveLeft());
            _myMoves.Add(new MoveRight());
            _myMoves.Add(new MoveBackwardLeft());
            _myMoves.Add(new MoveBackwardRight());
            _myMoves.Add(new MoveForwardLeft());
            _myMoves.Add(new MoveForwardRight());
        }

        public override List<Square> GetPossibleMoves(Chessman chessman, ChessTable chessTable)
        {
            List<Square> possibleMoves = new List<Square>();
            foreach (IBasicMove aBasicMove in _myMoves)
            {
                Square nextPossibleSquare = aBasicMove.GetNextSquare(chessman, chessTable);
                if (nextPossibleSquare != null)
                {
                    possibleMoves.Add(nextPossibleSquare);
                }
            }
            return possibleMoves;
        }
    }
}