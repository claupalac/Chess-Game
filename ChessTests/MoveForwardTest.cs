using Xunit;

namespace ChessTests
{
    public class MoveForwardTest
    {
        [Theory]
        [InlineData(0,0)]
        private void SetMove_WithSymmetricChessTable_ShouldReturnSameValues(int initPosX, int initPosY)
        {
            int nextPosX = initPosX;
            int nextPosY = initPosY + 1;
            
            
        }
    }
}