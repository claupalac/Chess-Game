using System;
using Autofac.Extras.Moq;
using Castle.Components.DictionaryAdapter.Xml;
using Chess;
using Xunit;
using Moq;

namespace ChessTests
{
    public class ChessTableTest : IDisposable // with symmetric ChessTable 8x8
    {
        private ChessTable _chessTable;
        public ChessTableTest()
        {
            _chessTable = new ChessTable(8,8);
        }
        public void Dispose()
        {
            _chessTable = null;
        }
        
        [Fact]
        void IsValidPosition_WithPositiveAndInRangeNumbers_ShouldReturnTrue()
        {
            int posX = 5;
            int posY = 4;
            
            bool actual = _chessTable.IsValidPosition(posX, posY);
            
            Assert.True(actual);
        }

        [Fact]
        public void PutChessman_WithValidChessmanPositionAndSymmetricTable_ShouldReturnTheSameChessmanFromChessTable()
        {
            int posX = 5;
            int posY = 4;
            var mock = new Mock<IChessman>();
            
            ISquare actual = _chessTable.PutChessman(mock.Object, posX, posY);
            
            Assert.Equal(mock.Object,actual.MyChessman);
        }
    }

}