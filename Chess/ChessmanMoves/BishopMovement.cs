using System.Collections.Generic;

namespace Chess
{
    public class BishopMovement : ChessmanMovement
    {
        public BishopMovement()
        {
            moves.Add(new MoveForwardRight());
            moves.Add(new MoveBackwardRight());
            moves.Add(new MoveBackwardLeft());
            moves.Add(new MoveForwardLeft());
        }

        public override List<IPosition> GetPossibleMoves(IPosition oPosition, IChessTable chessTable)
        {
            List<IPosition> possibleMoves = new List<IPosition>();
            foreach (IMove aBasicMove in moves)
            {
                IPosition nextPosition = aBasicMove.GetMove(oPosition);
                while (chessTable.IsValidPosition(nextPosition))
                {
                    possibleMoves.Add(nextPosition);
                    nextPosition = aBasicMove.GetMove(nextPosition);
                }
            }
            return possibleMoves;
        }
    }
}