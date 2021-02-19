using Chess;
using Moq;
using Xunit;

namespace ChessTests
{
    public class MoveForwardTest
    {
        private MoveForward _moveForward;
        public MoveForwardTest()
        {
            _moveForward = new MoveForward();
        }
        [Fact]
        void GetMove_WithPositivePositionValues_ShouldReturnPositionYPlusOne()
        {
            int oPositionX = 0;
            int oPositionY = 0;
            int expected = 1;
            var oPosition = new Mock<IPosition>();
            oPosition.Setup(x => x.PositionX).Returns(oPositionX);
            oPosition.Setup(x => x.PositionY).Returns(oPositionY);

            var actual = _moveForward.GetMove(oPosition.Object);
            
            Assert.Equal(expected,actual.PositionY);
        }
    }
}