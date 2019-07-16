using System;

namespace app {
    public class Bingo {
        private int Rows, Columns;

        public Bingo(int rows, int columns) {
            this.Rows = rows;
            this.Columns = columns;
        }

        public int[,] NewBoard() {
            return new int[,] {
                {1, 2},
                {3, 4},
            };
        }
    }
}
