using System.Collections.Generic;

namespace Chess
{
    public class KingMovement : ChessmanMovement
    {
        //private const int Range = 1;
        public KingMovement()
        {
            moves.Add( new MoveForward());
            moves.Add(new MoveBackward());
            moves.Add(new MoveLeft());
            moves.Add(new MoveRight());
            moves.Add(new MoveBackwardLeft());
            moves.Add(new MoveBackwardRight());
            moves.Add(new MoveForwardLeft());
            moves.Add(new MoveForwardRight());
        }
        public override List<IPosition> GetPossibleMoves(IPosition oPosition, IChessTable chessTable)
        {
            List<IPosition> possibleMoves = new List<IPosition>();
            foreach (var aMove in moves)
            {
                if (chessTable.IsValidPosition(aMove.GetMove(oPosition)))
                {
                    possibleMoves.Add(aMove.GetMove(oPosition));
                }
            }
            
            return possibleMoves;
        }
    }
}