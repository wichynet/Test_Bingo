using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formula
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] input1 = { 3, 4, 8, 13, 18, 19, 23 };
            int[] input2 = { 1, 13, 19, 25, 23, 2 };
            int[] input3 = { 2, 1, 12, 15, 6, 18, 16, 4, 3, 21, 11 };

            Console.WriteLine("Input1 = " + (BingoResult(input1) ? "Bingo" : "Not Bingo"));
            Console.WriteLine("Input2 = " + (BingoResult(input2) ? "Bingo" : "Not Bingo"));
            Console.WriteLine("Input3 = " + (BingoResult(input3) ? "Bingo" : "Not Bingo"));

            Console.ReadLine();
        }

        public static bool BingoResult(int[] input)
        {
            List<bool> bingoBoard = new List<bool>();
            for (int i = 0; i < 25; i++)
            {
                bingoBoard.Add(false);
            }

            foreach(int bingo in input)
            {
                bingoBoard[bingo - 1] = true;
            }

            if (bingoBoard[0] && bingoBoard[1] && bingoBoard[2] && bingoBoard[3] && bingoBoard[4])
                return true;
            else if (bingoBoard[5] && bingoBoard[6] && bingoBoard[7] && bingoBoard[8] && bingoBoard[9])
                return true;
            else if (bingoBoard[10] && bingoBoard[11] && bingoBoard[12] && bingoBoard[13] && bingoBoard[14])
                return true;
            else if (bingoBoard[15] && bingoBoard[16] && bingoBoard[17] && bingoBoard[18] && bingoBoard[19])
                return true;
            else if (bingoBoard[20] && bingoBoard[21] && bingoBoard[22] && bingoBoard[23] && bingoBoard[24])
                return true;

            else if (bingoBoard[0] && bingoBoard[5] && bingoBoard[10] && bingoBoard[15] && bingoBoard[20])
                return true;
            else if (bingoBoard[1] && bingoBoard[6] && bingoBoard[11] && bingoBoard[16] && bingoBoard[21])
                return true;
            else if (bingoBoard[2] && bingoBoard[7] && bingoBoard[12] && bingoBoard[17] && bingoBoard[22])
                return true;
            else if (bingoBoard[3] && bingoBoard[8] && bingoBoard[13] && bingoBoard[18] && bingoBoard[23])
                return true;
            else if (bingoBoard[4] && bingoBoard[9] && bingoBoard[14] && bingoBoard[19] && bingoBoard[24])
                return true;

            else if (bingoBoard[0] && bingoBoard[6] && bingoBoard[12] && bingoBoard[18] && bingoBoard[24])
                return true;
            else if (bingoBoard[4] && bingoBoard[8] && bingoBoard[13] && bingoBoard[17] && bingoBoard[21])
                return true;

            return false;
        }
        
    }
}
