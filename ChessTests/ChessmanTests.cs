using System;
using Chess;
using Moq;
using Xunit;

namespace ChessTests
{
    public class ChessmanTests : IDisposable

    {
        private Chessman subject;
        public ChessmanTests()
        {
            
        }
        public void Dispose()
        {
            subject = null;
        }

        [Fact]
        void GetMovement_WithAValidChessmanMovement_ShouldReturnTheSameChessmanMovement()
        {
            var mock = new Mock<IChessmanMovement>();
            ChessmanTestClass chessman= new ChessmanTestClass(mock.Object);

            var actual = chessman.GetMovement();
            Assert.Equal(mock.Object, actual);
        }
        
        public class ChessmanTestClass : Chessman
        {
            public ChessmanTestClass(IChessmanMovement moves) : base(moves)
            {
            }
        }
    }
}