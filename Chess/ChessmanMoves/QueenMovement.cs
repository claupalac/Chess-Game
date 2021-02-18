using System.Collections.Generic;

namespace Chess
{
    public class QueenMovement : ChessmanMovement
    {
        public QueenMovement()
        {
            moves.Add( new MoveForward());
            moves.Add(new MoveForwardRight());
            moves.Add(new MoveRight());
            moves.Add(new MoveBackwardRight());
            moves.Add(new MoveBackward());
            moves.Add(new MoveBackwardLeft());
            moves.Add(new MoveLeft());
            moves.Add(new MoveForwardLeft());
           
        }
        public override List<IPosition> GetPossibleMoves(IPosition oPosition, IChessTable chessTable)
        {
            List<IPosition> possibleMoves = new List<IPosition>();
            foreach (var aMove in moves)
            {
                IPosition nextPosition = aMove.GetMove(oPosition);
                while (chessTable.IsValidPosition(nextPosition))
                {
                    possibleMoves.Add(nextPosition);
                    nextPosition = aMove.GetMove(nextPosition);
                }
            }

            return possibleMoves;
        }
    }
}