using System;
using System.Text;

namespace test_3
{
    class Program
    {
        static int[] amountOfBoatToRent(int seats)
        {
            int cheapSeatCost = ((seats / 5) + 1) * 4;
            if (cheapSeatCost == 4)
            {
                cheapSeatCost++;
            }
            int tempCheapSeatCost = cheapSeatCost;
            int largeSize = 0, mediumSize = 0, tinySize = 0;
            if (tempCheapSeatCost % 12 != 0)
            {
                if (tempCheapSeatCost % 12 >= 8)
                {
                    largeSize = tempCheapSeatCost / 12;
                    tempCheapSeatCost -= (largeSize * 12);
                }
            }
            else
            {
                largeSize = tempCheapSeatCost / 12;
                tempCheapSeatCost -= (largeSize * 12);
            }
            if (tempCheapSeatCost % 8 != 0)
            {
                if (tempCheapSeatCost % 8 >= 5)
                {
                    mediumSize = tempCheapSeatCost / 8;
                    tempCheapSeatCost -= (mediumSize * 8);
                }
            }
            else
            {
                mediumSize = tempCheapSeatCost / 8;
                tempCheapSeatCost -= (mediumSize * 8);
            }
            tinySize = tempCheapSeatCost / 5;
            return new int[] { largeSize, mediumSize, tinySize, cheapSeatCost };
        }

        static void print(int[] arrays)
        {
            if (arrays[0] > 0)
            {
                Console.Write("Large = {0} ", arrays[0]);
            }
            if (arrays[1] > 0)
            {
                Console.Write("Medium = {0} ", arrays[1]);
            }
            if (arrays[2] > 0)
            {
                Console.Write("Tiny = {0} ", arrays[2]);
            }
            Console.WriteLine(", Cost = {0}$", arrays[3]);
        }

        static void Main(string[] args)
        {
            print(amountOfBoatToRent(4));
            print(amountOfBoatToRent(16));
            print(amountOfBoatToRent(23));
            print(amountOfBoatToRent(36));
        }
    }
}
