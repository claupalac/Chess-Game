using System;
using System.Collections.Generic;
using Chess.Factory;

namespace Chess
{
    public class ChessTable : IChessTable
    {
        private readonly IChessman[,] _chessTable;
        private  int _columnLimit;
        private  int _rowLimit;
        private const int MaxLimitTableSize = 100;
        private const int MinLimitTableSize = 0;

        private int ColumnLimit
         {
             get => _columnLimit;
             set
             {
                 if (value < MinLimitTableSize || value > MaxLimitTableSize) throw new ArgumentException("Invalid Value");
                 _columnLimit = value;
             }
         }

        private int RowLimit
                {
                    get => _rowLimit;
                    set 
                    {
                        if (value < MinLimitTableSize || value > MaxLimitTableSize) throw new ArgumentException("Invalid Value");
                        _rowLimit = value;
                    }
                }

         public ChessTable(int columnLimit, int rowLimit)
                {
                    ColumnLimit = columnLimit;
                    RowLimit = rowLimit;
                    _chessTable = new IChessman[ColumnLimit,RowLimit];
                }
         
        public bool IsValidPosition(int positionX, int positionY)
        {
            if (positionX >= 0 && positionX < ColumnLimit && positionY < RowLimit && positionY >= 0)
            {
                return _chessTable[positionX, positionY] == null;
            }
            else return false;
        }
        
        public void SetChessman(IChessman chessman, int posX, int posY)
        {
            if (IsValidPosition(posX,posY))
            {
                _chessTable[posX, posY] = chessman;
            }
            else
                throw new ArgumentException("Invalid action");
        }
        
    }
}