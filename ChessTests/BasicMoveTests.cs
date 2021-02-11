using System;
using Chess;
using Moq;
using Xunit;

namespace ChessTests
{
    public class BasicMoveTests : IDisposable
    {
        public BasicMoveTests()
        {
            
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        [Fact]
        void MoveFormward_WithValidInitPos_ShouldReturnForwardSquare()
        {
            int initPosX = 0;
            int initPosY = 0;
            Square initSquare = new Square(initPosX, initPosY);
            var chessmanMock = new Mock<IChessman>();
            chessmanMock.Setup(x => x.MySquare).Returns(initSquare);

            var tableMock = new Mock<IChessTable>();
            tableMock.Setup(tableMock=>tableMock.GetSquare()).Returns()

            IBasicMove subject = new MoveForward();
            
         

        }
    }
}