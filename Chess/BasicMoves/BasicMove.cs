namespace Chess
{
    public abstract class BasicMove : IBasicMove
    {
        protected int _nextPositionX;
        protected int _nextPositionY;
        private Chessman _chessman;
        private ChessTable _chessTable;
        protected BasicMove()
        {
            
        }
        public void SetMove(Chessman chessman, ChessTable chessTable)
        {
            this._nextPositionX = chessman.MySquare.PositionX;
            this._nextPositionY = chessman.MySquare.PositionY;
            _chessTable = chessTable;
            _chessman = chessman;
        }

        public Square GetNextSquare(Chessman chessman, ChessTable chessTable)
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