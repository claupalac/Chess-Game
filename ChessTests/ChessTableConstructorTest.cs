using System;
using Chess;
using Xunit;

namespace ChessTests
{
    public class ChessTableConstructorTest
    {
        private ChessTable _chessTable;
        public ChessTableConstructorTest()
        {
            _chessTable = new ChessTable();
        }
        public void Dispose()
        {
            _chessTable = null;
        }
        
        [Fact]
        void GetColumnLimit_WithPositiveColumnLimit_ShouldReturnSameValue()
        {
            int columnLimit = 8;
            int expected = 8;
            _chessTable = new ChessTable(columnLimit, columnLimit);
            
            int actual = _chessTable.GetColumnLimit();

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(8, 8)]
        [InlineData(23, 23)]
        void GetRowLimit_withPositiveRowLimits_ShouldReturnSameValue(int rowLimit,int expected)
        {
            _chessTable = new ChessTable(10, rowLimit);

            int actual = _chessTable.GetRowLimit();
            
            Assert.Equal(expected,actual);
        }

        [Theory]
        [InlineData(100)]
        [InlineData(0)]
        void SetColumnLimit_InvalidValue_ShouldFail(int columnValue)
        {
            Assert.Throws<ArgumentException>(() => _chessTable.SetColumnLimit(columnValue));
        }
    }
}