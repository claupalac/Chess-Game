using Chess;
using Moq;
using Xunit;

namespace ChessTests
{
    public class ChessTableTest
    {
        private ChessTable chessTable;

        public ChessTableTest()
        {
            chessTable = new ChessTable();
        }
        [Fact]
        void IsValidPosition_WithPositiveValuesAndDefaultSizeTable_ShouldReturnTrue()
        {
            int posX = 5;
            int posY = 5;
            var positionMock = new Mock<IPosition>();
            positionMock.Setup(x => x.PositionX).Returns(posX);
            positionMock.Setup(x => x.PositionY).Returns(posY);
            
            Assert.True(chessTable.IsValidPosition(positionMock.Object)); 
        }

        [Fact]
        void SetChessman_WithChessmanAndValidPosition_ShouldReturnFalseValidPosition()
        {
            int posX = 5;
            int posY = 5;
            var chessman = new Mock<IChessman>();
            var positionMock = new Mock<IPosition>();
            positionMock.Setup(x => x.PositionX).Returns(posX);
            positionMock.Setup(x => x.PositionY).Returns(posY);
            
            chessTable.SetChessman(chessman.Object,positionMock.Object);
            
            Assert.False(chessTable.IsValidPosition(positionMock.Object));

        }
    }
}