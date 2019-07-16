using System;
using Xunit;
using app;

namespace test
{
    public class BingoTest
    {
        [Fact]
        public void TestNewBoardNoInputShouldBe2DimensionalArrays()
        {
            // Arrange
            int[,] expectedBoard = new int[,] {
                {1, 2},
                {3, 4},
            };
            Bingo bingo = new Bingo(0, 0);

            // Act
            int[,] actualBoard = bingo.NewBoard();

            // Assert
            Assert.Equal(expectedBoard, actualBoard);
        }
    }
}
