using System.Collections.Generic;

namespace Chess
{
    public class PawnMovement : ChessmanMovement
    {
        private readonly bool _isFirstMove;
        public PawnMovement()
        {
            moves.Add(new MoveForward());
            _isFirstMove = true;
        }
        public override List<IPosition> GetPossibleMoves(IPosition oPosition, IChessTable chessTable)
        {
            List<IPosition> possibleMoves = new List<IPosition>();
            foreach (var aMove in moves)
            {
                IPosition nextPosition = aMove.GetMove(oPosition);
                if (chessTable.IsValidPosition(nextPosition))
                {
                    possibleMoves.Add(nextPosition);
                    nextPosition = aMove.GetMove(nextPosition);
                    if (_isFirstMove && chessTable.IsValidPosition(nextPosition))
                    {
                        possibleMoves.Add(nextPosition);
                    }
                }
            }

            return possibleMoves;
        }
    }
}