using System;
using Chess;
using Moq;
using Xunit;

namespace ChessTests
{
    public class SquareTests : IDisposable
    {
        private Square _square;
        public SquareTests()
        {
             _square = new Square();
        }

        public void Dispose()
        {
            _square = null;
        }

        [Fact]
        void PositionX_WithPositiveNumbers_ShouldReturnSameValue()
        {
            int expected = 10;
            
            _square.PositionX = 10;
            int actual = _square.PositionX;

            Assert.Equal(expected,actual);
        }
        
        [Fact]
        void PositionY_WithPositiveNumbers_ShouldReturnSameValue()
        {
            int expected = 10;
            
            _square.PositionY = 10;
            int actual = _square.PositionY;

            Assert.Equal(expected,actual);
        }

        [Fact]
        void MyChessman_WithFakeChessman_ShouldReturnSameChessman()
        {
            var mock = new Mock<Chessman>();

            _square.MyChessman = mock.Object;
            
            Assert.Equal(mock.Object, _square.MyChessman);
        }

        [Fact]
        void ShowPosition_WithPositiveNumbers_ShouldReturnPositionString()
        {
            var expected = "10,32";
            _square.PositionX = 10;
            _square.PositionY = 32;
            
            var actual = _square.ShowPosition();
            
            Assert.Equal(expected,actual);
        }

        [Fact]
        void IsEmpty_WithSquareFilled_ShouldReturnFalse()
        {
            var chessmanMock = new Mock<Chessman>();
            _square.MyChessman = chessmanMock.Object;
            
            bool actual = _square.IsEmpty();
            
            Assert.False(actual);
        }

        [Fact]
        private void SquareConstructor_WithPositiveValues_ShouldReturnSameSquare()
        {
            int posX = 10;
            int posY = 1;

            Square actual = new Square(posX, posY);
            
            Assert.Equal(posX,actual.PositionX);
            Assert.Equal(posY,actual.PositionY);
        }
    }
}