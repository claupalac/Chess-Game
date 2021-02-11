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
        void GetMovement_WithBishopInstance_ShouldReturnChessmanMovementInstance()
        {
            IChessman achessman = new Bishop();
            IChessmanMovement expected = new BishopMovement();

            ChessmanMovement actual = achessman.GetMovement();
            
            Assert.Equal(expected, actual));
        }
    }
}