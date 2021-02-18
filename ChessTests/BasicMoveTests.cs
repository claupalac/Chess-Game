using System;
using Chess;
using Moq;
using Xunit;

namespace ChessTests
{
    public class BasicMoveTests : IDisposable
    {
        private BasicMoveFakeClass subject;
        public BasicMoveTests()
        {
            subject = new BasicMoveFakeClass();
        }
        public void Dispose()
        {
            subject = null;
        }

        [Fact]
        void SetMove_WithKingAndSquareChessTable_ShouldChangeBasicMoveAttributes()
        {
            Chessman chessman = new King(new KingMovement());
            ChessTable chessTable = new ChessTable(8, 8);
            
            
        }
    }

    public class BasicMoveFakeClass : BasicMove
    {
        public override void SetChange()
        {
            _nextPositionX = 0;
            _nextPositionY = 0;
        }
    }
}

