using System;

namespace App
{
    public class Bingo
    {
        private int BoardSize;

        public Bingo(int boardSize)
        {
            this.BoardSize = boardSize;
        }

        public int[,] NewBoard()
        {
            return new int[,] {
                {7, 18, 8, 19, 2},
                {9, 17, 6, 14, 15},
                {20, 13, 1, 21, 10},
                {3, 4, 22, 16, 24},
                {12, 23, 11, 25, 5},
            };
        }

        public int[] ConvertNumberToIndex(int number)
        {
            return new int[] { number / BoardSize, number % BoardSize };
        }
    }
}
