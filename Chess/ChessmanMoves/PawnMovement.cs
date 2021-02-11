using System.Collections.Generic;

namespace Chess
{
    public class PawnMovement : ChessmanMovement
    {
        private bool isFirstMove;
        public PawnMovement()
        {
            _myMoves.Add(new MoveForward());
            isFirstMove = true;
        }

        public override List<ISquare> GetPossibleMoves(Chessman chessman, ChessTable chessTable)
        {
            List<ISquare> possibleMoves = new List<ISquare>();

            foreach (IBasicMove aBasicMove in _myMoves)
            {
                ISquare nextPossibleSquare = aBasicMove.GetNextSquare(chessman, chessTable);

                if (isFirstMove)
                {
                    int limitSteps = 0;
                    while (nextPossibleSquare != null && limitSteps < 2)
                    {
                        possibleMoves.Add(nextPossibleSquare);
                        Chessman chessmanShadow = new Pawn();
                        chessmanShadow.MySquare = nextPossibleSquare;
                        nextPossibleSquare = aBasicMove.GetNextSquare(chessmanShadow, chessTable);
                        limitSteps++;
                    }
                }
                else
                {
                    possibleMoves.Add(nextPossibleSquare);
                }
            }
            return possibleMoves;
        }
    }
}