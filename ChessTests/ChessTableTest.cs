using Chess;
using Xunit;

namespace ChessTests
{
    public class ChessTableTest
    {
        [Fact]
        void GetColumnLimit_WithPositiveColumnLimit_ShouldReturnSameValue()
        {
            ChessTable chessTable = new ChessTable(8, 8);
            int expected = 8;

            int actual = chessTable.GetColumnLimit();

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(8, 8)]
        [InlineData(23, 23)]
        [InlineData(65321, 65321)]
        void GetRowLimit_withPositiveRowLimits_ShouldReturnSameValue(int rowLimit,int expected)
        {
            ChessTable chessTable = new ChessTable(10, rowLimit);

            int actual = chessTable.GetRowLimit();
            
            Assert.Equal(expected,actual);
        }
        
        
    }
}