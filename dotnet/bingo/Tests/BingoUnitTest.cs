using System;
using Xunit;
using App;

namespace test
{
    public class BingoUnitTests
    {
        [Fact]
        public void TestNewBoardNoInputShouldBeBingoBoardSize5x5()
        {
            int expectedBingoBoardSize = 5 * 5;
            Bingo bingo = new Bingo(5);

            bingo.NewBoardGame();
            int actualBingoBoardSize = bingo.GetBoardGame().Length;

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

        [Fact]
        private void TestMarkNumberInput7ShouldBeBoardGameIndex0and0IsZero()
        {
            int[,] expectedBoardGame = new int[,] {
                {0, 18, 8, 19, 2},
                {9, 17, 6, 14, 15},
                {20, 13, 1, 21, 10},
                {3, 4, 22, 16, 24},
                {12, 23, 11, 25, 5},
            };
            Bingo bingo = new Bingo(5);
            bingo.NewBoardGame();

            bingo.MarkNumber(7);
            int[,] actualBoardGame = bingo.GetBoardGame();

            Assert.Equal(expectedBoardGame, actualBoardGame);
        }
    }
}
