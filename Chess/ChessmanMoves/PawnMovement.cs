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

        public override List<Square> GetPossibleMoves(Chessman chessman, ChessTable chessTable)
        {
            List<Square> possibleMoves = new List<Square>();

            foreach (IBasicMove aBasicMove in _myMoves)
            {
                Square nextPossibleSquare = aBasicMove.GetNextSquare(chessman, chessTable);

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