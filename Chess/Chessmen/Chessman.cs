using System.Collections.Generic;

namespace Chess
{
    public abstract class Chessman
    {
        public Square MySquare { get; set; }
        protected ChessmanMovement myMoves;

        protected Chessman( )
        {
        }

        public ChessmanMovement GetMovement()
        {
            return myMoves;
        }
    }
}