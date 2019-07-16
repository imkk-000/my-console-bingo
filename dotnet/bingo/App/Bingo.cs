using System;

namespace App
{
    public class Bingo
    {
        private int Rows, Columns;

        public Bingo()
        {
            this.Rows = 5;
            this.Columns = 5;
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
    }
}
