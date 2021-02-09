using System.Collections.Generic;

namespace Chess
{
    public class BishopMovement : ChessmanMovement
    {
        public BishopMovement()
        {
            _myMoves.Add(new MoveForwardRight());
            _myMoves.Add(new MoveBackwardRight());
            _myMoves.Add(new MoveBackwardLeft());
            _myMoves.Add(new MoveForwardLeft());
        }

        public override List<Square> GetPossibleMoves(Chessman chessman, ChessTable chessTable)
        {
            List<Square> possibleMoves = new List<Square>();

            foreach (IBasicMove aBasicMove in _myMoves)
            {
                Square nextPossibleSquare = aBasicMove.GetNextSquare(chessman, chessTable);
                while (nextPossibleSquare != null)
                {
                    possibleMoves.Add(nextPossibleSquare);
                    Chessman queenShadow = new Queen();
                    queenShadow.MySquare = nextPossibleSquare;
                    nextPossibleSquare = aBasicMove.GetNextSquare(queenShadow, chessTable);
                }
            }
            return possibleMoves;
        }
    }
}