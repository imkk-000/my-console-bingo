using System;

namespace test_1
{
    class Program
    {
        static int BingoRow = 5, BingoColumn = 5;
        static int[,] BingoBoard = null;

        static void GenerateNewBingoBoard()
        {
            BingoBoard = new int[,] {
                {7, 18, 8, 19, 2},
                {9, 17, 6, 14, 15},
                {20, 13, 1, 21, 10},
                {3, 4, 22, 16, 24,},
                {12, 23, 11, 25, 5},
            };
        }

        static void BingoMarkNumber(int selectNumber)
        {
            for (int col = 0; col < BingoColumn; col++)
            {
                for (int row = 0; row < BingoRow; row++)
                {
                    if (BingoBoard[col, row] == selectNumber)
                    {
                        BingoBoard[col, row] = 0;
                    }
                }
            }
        }

        static bool IsBingo()
        {
            int bingoHorizontalCounter = 0;
            int bingoVerticalCounter = 0;
            int bingoDiagonalDownCounter = 0;
            int bingoDiagonalUpCounter = 0;
            int diffBingoRowForUpDiagonal = 0;

            for (int col = 0; col < BingoColumn; col++)
            {
                // count bingo table
                for (int row = 0; row < BingoRow; row++)
                {
                    if (BingoBoard[col, row] == 0)
                    {
                        bingoHorizontalCounter++;
                    }
                    if (BingoBoard[row, col] == 0)
                    {
                        bingoVerticalCounter++;
                    }
                }
                if (BingoBoard[col, col] == 0)
                {
                    bingoDiagonalDownCounter++;
                }
                diffBingoRowForUpDiagonal = BingoRow - 1 - col;
                if (BingoBoard[col, diffBingoRowForUpDiagonal] == 0)
                {
                    bingoDiagonalUpCounter++;
                }

                // bingo?
                if (bingoHorizontalCounter == BingoRow)
                {
                    return true;
                }
                if (bingoVerticalCounter == BingoColumn)
                {
                    return true;
                }
                if (bingoDiagonalDownCounter == BingoColumn)
                {
                    return true;
                }
                if (bingoDiagonalUpCounter == BingoColumn)
                {
                    return true;
                }

                bingoHorizontalCounter = 0;
                bingoVerticalCounter = 0;
            }
            return false;
        }

        static string BingoGame(int[] selectNumbers)
        {
            GenerateNewBingoBoard();
            for (int i = 0; i < selectNumbers.Length; i++)
            {
                BingoMarkNumber(selectNumbers[i]);
            }
            return IsBingo() ? "Bingo" : "Not Bingo";
        }

        static void Main(string[] args)
        {
            // |
            Console.WriteLine(BingoGame(new int[] { 7, 9, 20, 3, 12 }));
            // -
            Console.WriteLine(BingoGame(new int[] { 7, 18, 8, 19, 2 }));
            // \
            Console.WriteLine(BingoGame(new int[] { 7, 17, 1, 16, 5 }));
            // /
            Console.WriteLine(BingoGame(new int[] { 2, 14, 1, 4, 12 }));
        }
    }
}
