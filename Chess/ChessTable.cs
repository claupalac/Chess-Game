namespace Chess
{
    public interface IChessTable
    {
        int GetColumnLimit();
        int GetRowLimit();
        bool IsValidPosition(int positionX, int positionY);
        void PutChessman(Chessman chessman, int positionX, int positionY);
        Square GetSquare(int posX, int posY);
    }

    public class ChessTable : IChessTable
    {
        private Square[,] _chessTable;
        private  int _columnLimit;
        private  int _rowLimit;

        public ChessTable(int columnLimit, int rowLimit)
        {
            this._columnLimit = columnLimit;
            this._rowLimit = rowLimit;
            this._chessTable = new Square[columnLimit,rowLimit];
            FillChessTable();
        }

        public int GetColumnLimit() => _columnLimit;
        public int GetRowLimit() => _rowLimit;

        private void FillChessTable()
        {
            for (int i = 0; i < _columnLimit; i++)
            {
                for (int j = 0; j < _rowLimit; j++)
                {
                    _chessTable[i, j] = new Square(i, j);
                }
            }
        }

        public bool IsValidPosition(int positionX, int positionY)
        {
            if (positionX >= 0 && positionX < _columnLimit && positionY < _rowLimit && positionY >= 0)
            {
                return _chessTable[positionX, positionY].IsEmpty();
            }
            else return false;
        }

        public void PutChessman(Chessman chessman, int positionX, int positionY)
        {
            if (!IsValidPosition(positionX, positionY) && _chessTable[positionX, positionY].IsEmpty())
            {
               return;
            }
            _chessTable[positionX, positionY].MyChessman = chessman;
            chessman.MySquare = _chessTable[positionX, positionY];
        }

        public Square GetSquare(int posX, int posY)
        {
            return _chessTable[posX,posY];
        }
    }
}