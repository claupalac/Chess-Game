using System;
using Chess;
using Xunit;

namespace ChessTests
{
    public class PositionTest : IDisposable
    {
        private Position position;
        public PositionTest()
        {
            position = new Position();
        }
        public void Dispose()
        {
            position = null;
        }

        [Fact]
        void GetPositionX_WithPositiveValue_ShouldReturnSameValue()
        {
            int expected = 10;
            int value = 10;

            position.PositionX = value;
            
            Assert.Equal(expected,position.PositionX);
        }
        [Fact]
        void GetPositionX_WithNegativeValue_ShouldReturnSameValue()
        {
            int expected = -10;
            int value = -10;

            position.PositionX = value;
            
            Assert.Equal(expected,position.PositionX);
        }
        [Fact]
        void GetPositionY_WithPositiveValue_ShouldReturnSameValue()
        {
            int expected = 10;
            int value = 10;

            position.PositionY = value;
            
            Assert.Equal(expected,position.PositionY);
        }
        [Fact]
        void GetPositionY_WithNegativeValue_ShouldReturnSameValue()
        {
            int expected = -10;
            int value = -10;

            position.PositionY = value;
            
            Assert.Equal(expected,position.PositionY);
        }
    }
}