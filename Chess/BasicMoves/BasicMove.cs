﻿namespace Chess
{
    public abstract class BasicMove : IBasicMove
    {
        protected int _nextPositionX;

        public int NextPositionX => _nextPositionX;

        public int NextPositionY => _nextPositionY;

        protected int _nextPositionY;
        private IChessman _chessman;
        private IChessTable _chessTable;
        protected BasicMove()
        {
            
        }
        public void SetMove(IChessman chessman, IChessTable chessTable)
        {
            this._nextPositionX = chessman.MySquare.PositionX;
            this._nextPositionY = chessman.MySquare.PositionY;
            _chessTable = chessTable;
            _chessman = chessman;
        }

        public ISquare GetNextSquare(IChessman chessman, IChessTable chessTable)
        {
            SetMove(chessman,chessTable);
            SetChange();
            return chessTable.IsValidPosition(_nextPositionX, _nextPositionY) ? chessTable.GetSquare(_nextPositionX,_nextPositionY) : null;
        }

        public virtual void SetChange()
        {
            
        }
    }
}