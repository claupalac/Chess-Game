using System;
using System.Collections.Generic;
using Chess;
using Moq;
using Xunit;

namespace ChessTests
{
    public class KingMovementTest : IDisposable
    {
        private KingMovement _kingMovement;
        public KingMovementTest()
        {
            _kingMovement = new KingMovement();
        }

        public void Dispose()
        {
            _kingMovement = null;
        }

        [Theory]
        [InlineData(0,0)]
        void GetPossibleMoves_WithEmptyChessTable_ShouldReturnList(int initPosX, int initPosY)
        {
            
            var chessman = new Mock<IChessman>();
            chessman.Setup(x => x.GetMovement()).Returns(_kingMovement);
            chessman.Setup(x => x.MySquare.PositionX).Returns(initPosX);
            chessman.Setup(x => x.MySquare.PositionY).Returns(initPosY);

            var chessTableMock = new Mock<IChessTable>();
            chessTableMock.Setup(x => x.GetSquare(initPosX, initPosY)).Returns(new Square(initPosX, initPosY));
            
            List<ISquare>actual =  _kingMovement.GetPossibleMoves(chessman.Object , chessTableMock.Object);
            Assert.NotEmpty(actual);
        }
    }
}