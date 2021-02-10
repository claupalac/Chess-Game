using System;
using Chess;
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
    }
}