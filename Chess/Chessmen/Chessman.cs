﻿using System.Collections.Generic;

namespace Chess
{
    public abstract class Chessman : IChessman
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