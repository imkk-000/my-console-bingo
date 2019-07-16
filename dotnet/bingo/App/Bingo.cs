using System;

namespace App
{
    public class Bingo
    {
        private int BoardSize;
        private int[,] BoardGame;

        public Bingo(int boardSize)
        {
            this.BoardSize = boardSize;
        }

        public void NewBoardGame()
        {
            this.BoardGame = new int[,] {
                {7, 18, 8, 19, 2},
                {9, 17, 6, 14, 15},
                {20, 13, 1, 21, 10},
                {3, 4, 22, 16, 24},
                {12, 23, 11, 25, 5},
            };
        }

        public int[,] GetBoardGame()
        {
            return this.BoardGame;
        }

        public int[] ConvertNumberToIndex(int number)
        {
            return new int[] { number / BoardSize, number % BoardSize };
        }

        public void MarkNumber(int number)
        {
            for (int col = 0; col < BoardSize; col++)
            {
                for (int row = 0; row < BoardSize; row++)
                {
                    if (this.BoardGame[col, row] == number)
                    {
                        this.BoardGame[col, row] = 0;
                    }
                }
            }
        }

        public bool CheckBingoWithIndexDistance(int startIndex, int indexDistanceNumber)
        {
            int[] arrayIndex;
            int counter = 0;
            for (int i = 0, id = startIndex; i < BoardSize; i++, id += indexDistanceNumber)
            {
                arrayIndex = ConvertNumberToIndex(id);
                if (this.BoardGame[arrayIndex[0], arrayIndex[1]] == 0)
                {
                    counter++;
                }
            }
            return (this.BoardSize == counter);
        }

        public bool CheckBingo()
        {
            if (CheckBingoDiagonalDirection())
            {
                return true;
            }
            for (int i = 0; i < BoardSize; i++)
            {
                if (CheckBingoHorizontalDirection(i * this.BoardSize))
                {
                    return true;
                }
                if (CheckBingoVerticalDirection(i))
                {
                    return true;
                }
            }
            return false;
        }

        public bool CheckBingoHorizontalDirection(int startIndex)
        {
            return CheckBingoWithIndexDistance(startIndex, 1);
        }

        public bool CheckBingoVerticalDirection(int startIndex)
        {
            return CheckBingoWithIndexDistance(startIndex, this.BoardSize);
        }

        public bool CheckBingoDiagonalDirection()
        {
            return CheckBingoWithIndexDistance(this.BoardSize - 1, 4) || CheckBingoWithIndexDistance(0, 6);
        }
    }
}
