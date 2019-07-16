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
            Bingo bingo = new Bingo();

            int[,] bingoBoard = bingo.NewBoard();
            int actualBingoBoardSize = bingoBoard.Length;

            Assert.Equal(expectedBingoBoardSize, actualBingoBoardSize);
        }
    }
}
