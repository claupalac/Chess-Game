using System;

namespace Chess
{
    public interface IChessTable
    {
        void SetColumnLimit(int newColumnLimit);
        void SetRowLimit(int newRowLimit);
        int GetColumnLimit();
        int GetRowLimit();
        bool IsValidPosition(int positionX, int positionY);
        Square PutChessman(Chessman chessman, int positionX, int positionY);
        Square GetSquare(int posX, int posY);
    }

    public class ChessTable : IChessTable
    {
        private Square[,] _chessTable;
        private  int _columnLimit;
        private  int _rowLimit;

        public ChessTable(int columnLimit, int rowLimit)
        {
            if (!IsValidLimit(columnLimit) || !IsValidLimit(rowLimit))
            {
                throw new ArgumentException("Invalid value. Must be 0-99.");
            }
            this._columnLimit = columnLimit;
            this._rowLimit = rowLimit;
            this._chessTable = new Square[columnLimit,rowLimit];
            FillChessTable();
        }

        public ChessTable()
        {
            
        }

        public int GetColumnLimit() => _columnLimit;
        public int GetRowLimit() => _rowLimit;

        public void SetRowLimit(int newRowLimit)
        {
            if (!IsValidLimit(newRowLimit))
            {
                throw new ArgumentException("Invalid value. Must be 0-99.");
            }
            _rowLimit = newRowLimit;
        }
        
        public void SetColumnLimit(int newColumnLimit)
        {
            if (!IsValidLimit(newColumnLimit))
            {
                throw new ArgumentException("Invalid value. Must be 0-99.");
            }
        }

        private void FillChessTable()
        {
            for (int i = 0; i < _columnLimit; i++)
            {
                for (int j = 0; j < _rowLimit; j++)
                {
                    _chessTable[i, j] = (Square) Factory.CreateSquare(i,j);
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

        public Square PutChessman(Chessman chessman, int positionX, int positionY)
        {
            if (!IsValidPosition(positionX, positionY) || !_chessTable[positionX, positionY].IsEmpty())
            {
               throw new ArgumentException("Not valid position");
            }
            _chessTable[positionX, positionY].MyChessman = chessman;
            chessman.MySquare = _chessTable[positionX, positionY];
            return _chessTable[positionX, positionY];
        }

        public Square GetSquare(int posX, int posY)
        {
            return _chessTable[posX,posY];
        }

        private bool IsValidLimit(int limit)
        {
            if (limit < 100 && limit > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}