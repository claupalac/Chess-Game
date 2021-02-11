using System.Collections.Generic;

namespace Chess
{
    public class RookMovement : ChessmanMovement
    {
        public RookMovement()
        {
            _myMoves.Add(new MoveForward());
            _myMoves.Add(new MoveRight());
            _myMoves.Add(new MoveBackward());
            _myMoves.Add(new MoveLeft());
        }
        public override List<ISquare> GetPossibleMoves(Chessman chessman, ChessTable chessTable)
        {
            List<ISquare> possibleMoves = new List<ISquare>();

            foreach (IBasicMove aBasicMove in _myMoves)
            {
                ISquare nextPossibleSquare = aBasicMove.GetNextSquare(chessman, chessTable);
                while (nextPossibleSquare != null)
                {
                    possibleMoves.Add(nextPossibleSquare);
                    Chessman rookShadow = new Rook();
                    rookShadow.MySquare = nextPossibleSquare;
                    nextPossibleSquare = aBasicMove.GetNextSquare(rookShadow, chessTable);
                }
            }
            return possibleMoves;
        }
    }
}