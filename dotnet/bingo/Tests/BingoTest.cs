using System;
using Xunit;
using App;

namespace test
{
    public class BingoTest
    {
        [Fact]
        public void TestNewBoardNoInputShouldBeBingoBoardSize5x5()
        {
            int expectedBingoBoardSize = 5 * 5;
            Bingo bingo = new Bingo(5);

            int[,] bingoBoard = bingo.NewBoard();
            int actualBingoBoardSize = bingoBoard.Length;

            Assert.Equal(expectedBingoBoardSize, actualBingoBoardSize);
        }

        [Fact]
        private void TestConvertNumberToIndexInput0ShouldBeArray00()
        {
            int[] expectedArray = new int[] { 0, 0 };
            Bingo bingo = new Bingo(5);

            int[] actualIndex = bingo.ConvertNumberToIndex(0);

            Assert.Equal(expectedArray, actualIndex);
        }
    }
}
