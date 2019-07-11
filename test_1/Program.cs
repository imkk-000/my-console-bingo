using System;

namespace test_1
{
    class Program
    {
        static int BingoRow = 5, BingoColumn = 5;
        static int[,] BingoBoard = null;
        static void generateBingoBoard()
        {
            BingoBoard = new int[,] {
                {7, 18, 8, 19, 2},
                {9, 17, 6, 14, 15},
                {20, 13, 1, 21, 10},
                {3, 4, 22, 16, 24,},
                {12, 23, 11, 25, 5},
            };
        }

        static void findAndMarkNumber(int selectNumber)
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

        static bool findBingo()
        {
            int bingoHorizontalCounter = 0, bingoVerticalCounter = 0;
            for (int col = 0; col < BingoColumn; col++)
            {
                bingoHorizontalCounter = 0;
                bingoVerticalCounter = 0;
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
                if (bingoHorizontalCounter == BingoRow)
                {
                    return true;
                }
                if (bingoVerticalCounter == BingoColumn)
                {
                    return true;
                }
            }

            return false;
        }

        static bool isBingo()
        {
            return findBingo();
        }

        static bool BingoGame(int[] selectNumbers)
        {
            generateBingoBoard();

            for (int i = 0; i < selectNumbers.Length; i++)
            {
                findAndMarkNumber(selectNumbers[i]);
            }

            return isBingo();
        }

        static void Main(string[] args)
        {
            // |
            Console.WriteLine(BingoGame(new int[] { 7, 9, 20, 3, 12 }));
            // -
            Console.WriteLine(BingoGame(new int[] { 7, 18, 8, 19, 2 }));
            // \
            Console.WriteLine(BingoGame(new int[] { 7, 17, 1, 16, 5 }));
        }
    }
}
