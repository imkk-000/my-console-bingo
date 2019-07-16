using System;
using Xunit;
using App;

namespace test
{
public class BingoIntegrationTests {

        [Fact]
        private void TestCheckBingoWithIndexDistanceInputStartIndex10IndexDistance1ShouldBeTrue()
        {
            bool expectedCheckBingo = true;
            Bingo bingo = new Bingo(5);
            bingo.NewBoardGame();
            bingo.MarkNumber(20);
            bingo.MarkNumber(13);
            bingo.MarkNumber(1);
            bingo.MarkNumber(21);
            bingo.MarkNumber(10);

            bool actualCheckBingo = bingo.CheckBingoWithIndexDistance(10, 1);

            Assert.Equal(expectedCheckBingo, actualCheckBingo);
        }

        [Fact]
        private void TestCheckBingoWithIndexDistanceInputStartIndex2IndexDistance5ShouldBeTrue() {
            bool expectedCheckBingo = true;
            Bingo bingo = new Bingo(5);
            bingo.NewBoardGame();
            bingo.MarkNumber(8);
            bingo.MarkNumber(6);
            bingo.MarkNumber(1);
            bingo.MarkNumber(22);
            bingo.MarkNumber(11);

            bool actualCheckBingo = bingo.CheckBingoWithIndexDistance(2, 5);

            Assert.Equal(expectedCheckBingo, actualCheckBingo);
        }

        [Fact]
        private void TestCheckBingoWithIndexDistanceInputStartIndex4IndexDistance4ShouldBeTrue()
        {
            bool expectedCheckBingo = true;
            Bingo bingo = new Bingo(5);
            bingo.NewBoardGame();
            bingo.MarkNumber(2);
            bingo.MarkNumber(14);
            bingo.MarkNumber(1);
            bingo.MarkNumber(4);
            bingo.MarkNumber(12);

            bool actualCheckBingo = bingo.CheckBingoWithIndexDistance(4, 4);

            Assert.Equal(expectedCheckBingo, actualCheckBingo);
        }

        [Fact]
        private void TestCheckBingoWithIndexDistanceInputStartIndex0IndexDistance6ShouldBeTrue()
        {
            bool expectedCheckBingo = true;
            Bingo bingo = new Bingo(5);
            bingo.NewBoardGame();
            bingo.MarkNumber(7);
            bingo.MarkNumber(17);
            bingo.MarkNumber(1);
            bingo.MarkNumber(16);
            bingo.MarkNumber(5);

            bool actualCheckBingo = bingo.CheckBingoWithIndexDistance(0, 6);

            Assert.Equal(expectedCheckBingo, actualCheckBingo);
        }

        [Fact]
        private void TestCheckBingoWithIndexDistanceInputStartIndex0IndexDistance1ShouldBeFalse()
        {
            bool expectedCheckBingo = false;
            Bingo bingo = new Bingo(5);
            bingo.NewBoardGame();
            bingo.MarkNumber(7);
            bingo.MarkNumber(18);
            bingo.MarkNumber(2);

            bool actualCheckBingo = bingo.CheckBingoWithIndexDistance(0, 1);

            Assert.Equal(expectedCheckBingo, actualCheckBingo);
        }

        [Fact]
        private void TestCheckBingoInputBingoBoardHorizontalDirectionShouldBeBingo() {
            bool expectedCheckBingo = true;
            Bingo bingo = new Bingo(5);
            bingo.NewBoardGame();
            bingo.MarkNumber(20);
            bingo.MarkNumber(13);
            bingo.MarkNumber(1);
            bingo.MarkNumber(21);
            bingo.MarkNumber(10);

            bool actualCheckBingo = bingo.CheckBingo();

            Assert.Equal(expectedCheckBingo, actualCheckBingo);
        }

        [Fact]
        private void TestCheckBingoInputBingoBoardVerticalDirectionShouldBeBingo() {
            bool expectedCheckBingo = true;
            Bingo bingo = new Bingo(5);
            bingo.NewBoardGame();
            bingo.MarkNumber(8);
            bingo.MarkNumber(6);
            bingo.MarkNumber(1);
            bingo.MarkNumber(22);
            bingo.MarkNumber(11);

            bool actualCheckBingo = bingo.CheckBingo();

            Assert.Equal(expectedCheckBingo, actualCheckBingo);
        }

        [Fact]
        private void TestCheckBingoInputBingoBoardDiagonalUpDirectionShouldBeBingo() {
            bool expectedCheckBingo = true;
            Bingo bingo = new Bingo(5);
            bingo.NewBoardGame();
            bingo.MarkNumber(12);
            bingo.MarkNumber(4);
            bingo.MarkNumber(1);
            bingo.MarkNumber(14);
            bingo.MarkNumber(2);

            bool actualCheckBingo = bingo.CheckBingo();

            Assert.Equal(expectedCheckBingo, actualCheckBingo);
        }

        [Fact]
        private void TestCheckBingoInputBingoBoardDiagonalDownDirectionShouldBeBingo() {
            bool expectedCheckBingo = true;
            Bingo bingo = new Bingo(5);
            bingo.NewBoardGame();
            bingo.MarkNumber(7);
            bingo.MarkNumber(17);
            bingo.MarkNumber(1);
            bingo.MarkNumber(16);
            bingo.MarkNumber(5);

            bool actualCheckBingo = bingo.CheckBingo();

            Assert.Equal(expectedCheckBingo, actualCheckBingo);
        }
}
}
