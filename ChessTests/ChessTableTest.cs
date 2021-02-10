using System;
using Autofac.Extras.Moq;
using Castle.Components.DictionaryAdapter.Xml;
using Chess;
using Xunit;
using Moq;

namespace ChessTests
{
    public class ChessTableTest : IDisposable
    {
        private ChessTable _chessTable;
        public ChessTableTest()
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
            
            _chessTable.SetColumnLimit(columnLimit);
            int actual = _chessTable.GetColumnLimit();

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(8, 8)]
        [InlineData(23, 23)]
        [InlineData(65321, 65321)]
        void GetRowLimit_withPositiveRowLimits_ShouldReturnSameValue(int rowLimit,int expected)
        {
            ChessTable chessTable = new ChessTable(10, rowLimit);

            int actual = chessTable.GetRowLimit();
            
            Assert.Equal(expected,actual);
        }

        [Theory]
        [InlineData(100)]
        [InlineData(0)]
        void SetColumnLimit_InvalidValue_ShouldFail(int columnValue)
        {
            Assert.Throws<ArgumentException>(() => _chessTable.SetColumnLimit(columnValue));
        }

        [Fact]
        void IsValidPosition_WithPositiveAndInRangeNumbers_ShouldReturnTrue()
        {
            int columnLimit = 8;
            int rowLimit = 8;
            _chessTable = new ChessTable(columnLimit,rowLimit);
            int posX = 5;
            int posY = 4;
            
            bool actual = _chessTable.IsValidPosition(posX, posY);
            
            Assert.True(actual);
        }

        [Fact]
        public void PutChessman_WithValidChessmanPositionAnd8x8Table_ShouldReturnTheSameChessmanFromChessTable()
        {
            _chessTable = new ChessTable(8, 8);
            int posX = 5;
            int posY = 4;
            var mock = new Mock<Chessman>();
            
            Square actual = _chessTable.PutChessman(mock.Object, posX, posY);
            
            Assert.Equal(mock.Object,actual.MyChessman);
        }
        
        
    }

}