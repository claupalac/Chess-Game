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
         
        public bool IsValidPosition(IPosition position)
        {
            if (position.PositionX >= 0 && position.PositionX < ColumnLimit && position.PositionY < RowLimit && position.PositionY >= 0)
            {
                return _chessTable[position.PositionX, position.PositionY] == null;
            }
            else return false;
        }
        
        public void SetChessman(IChessman chessman, IPosition position)
        {
            if (IsValidPosition(position))
            {
                _chessTable[position.PositionX, position.PositionY] = chessman;
            }
            else
                throw new ArgumentException("Invalid action");
        }
        
    }
}