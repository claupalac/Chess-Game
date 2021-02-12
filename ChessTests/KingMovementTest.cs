using System;
using System.Collections.Generic;
using Chess;
using Chess.Factory;
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
            chessman.Setup(x => x.MySquare).Returns(new Square(initPosX, initPosY));
            int columns = 8;
            int rows = 8;
            ChessTable chessTable = new ChessTable(columns,rows);
            chessTable.PutChessman(chessman.Object, initPosX, initPosY);
            List<ISquare>actual =  _kingMovement.GetPossibleMoves(chessman.Object , chessTable);
            Assert.NotEmpty(actual);
        }
    }
}