using System.Collections.Generic;

namespace Chess
{
    public class KnightMovement : ChessmanMovement
    {
        public KnightMovement()
        {
            moves.Add(new MoveForwardRightKnight());
            moves.Add(new MoveForwardLeftKnight());
            moves.Add(new MoveLeftForwardKnight());
            moves.Add(new MoveLeftBackwardKnight());
            moves.Add(new MoveRightForwardKnight());
            moves.Add(new MoveRightBackwardKnight());
            moves.Add(new MoveBackwardLeftKnight());
            moves.Add(new MoveBackwardRightKnight());
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