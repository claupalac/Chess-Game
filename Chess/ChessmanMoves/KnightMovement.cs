using System.Collections.Generic;

namespace Chess
{
    public class KnightMovement : ChessmanMovement
    {
        public KnightMovement()
        {
            _myMoves.Add(new MoveForwardRightKnight());
            _myMoves.Add(new MoveForwardLeftKnight());
            _myMoves.Add(new MoveLeftForwardKnight());
            _myMoves.Add(new MoveLeftBackwardKnight());
            _myMoves.Add(new MoveRightForwardKnight());
            _myMoves.Add(new MoveRightBackwardKnight());
            _myMoves.Add(new MoveBackwardLeftKnight());
            _myMoves.Add(new MoveBackwardRightKnight());
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
                    Chessman knightShodow = new Knight();
                    knightShodow.MySquare = nextPossibleSquare;
                    nextPossibleSquare = aBasicMove.GetNextSquare(knightShodow, chessTable);
                }
            }
            return possibleMoves;
        }
        
    }
}