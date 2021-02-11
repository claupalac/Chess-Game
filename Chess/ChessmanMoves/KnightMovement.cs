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
        public override List<ISquare> GetPossibleMoves(IChessman chessman, IChessTable chessTable)
        {
            List<ISquare> possibleMoves = new List<ISquare>();

            foreach (IBasicMove aBasicMove in _myMoves)
            {
                ISquare nextPossibleSquare = aBasicMove.GetNextSquare(chessman, chessTable);
                while (nextPossibleSquare != null)
                {
                    possibleMoves.Add(nextPossibleSquare);
                    Chessman knightShodow = new Knight(new KingMovement());
                    knightShodow.MySquare = nextPossibleSquare;
                    nextPossibleSquare = aBasicMove.GetNextSquare(knightShodow, chessTable);
                }
            }
            return possibleMoves;
        }
        
    }
}