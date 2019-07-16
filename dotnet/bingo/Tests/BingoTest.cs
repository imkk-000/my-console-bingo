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
        private void TestConvertNumberToIndexInput0ShouldBeArray0and0()
        {
            int[] expectedArray = new int[] { 0, 0 };
            Bingo bingo = new Bingo(5);

            int[] actualArray = bingo.ConvertNumberToIndex(0);

            Assert.Equal(expectedArray, actualArray);
        }

        [Fact]
        private void TestConvertNumberToIndexInput7ShouldBeArray1and2()
        {
            int[] expectedArray = new int[] { 1, 2 };
            Bingo bingo = new Bingo(5);

            int[] actualArray = bingo.ConvertNumberToIndex(7);

            Assert.Equal(expectedArray, actualArray);
        }

        [Fact]
        private void TestConvertNumberToIndexInput24ShouldBeArray4and4()
        {
            int[] expectedArray = new int[] { 4, 4 };
            Bingo bingo = new Bingo(5);

            int[] actualArray = bingo.ConvertNumberToIndex(24);

            Assert.Equal(expectedArray, actualArray);
        }
    }
}
