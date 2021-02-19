using System.Collections.Generic;

namespace Chess
{
    public class RookMovement : ChessmanMovement
    {
        public RookMovement()
        {
            moves.Add(new MoveForward());
            moves.Add(new MoveRight());
            moves.Add(new MoveBackward());
            moves.Add(new MoveLeft());
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