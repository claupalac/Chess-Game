using System.Collections.Generic;

namespace Chess
{
    public abstract class Chessman : IChessman
    {
        public ISquare MySquare { get; set; }
        protected IChessmanMovement myMoves;

        protected Chessman(IChessmanMovement moves)
        {
            myMoves = moves;
        }

       

        public IChessmanMovement GetMovement()
        {
            return myMoves;
        }
    }
}