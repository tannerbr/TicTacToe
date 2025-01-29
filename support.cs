using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class support
    {

        public static void printBoard(char[,] moves)
        {
            Console.WriteLine("Tic-Tac-Toe Board: ");

            for (int row = 0; row < 3; row++) // iterate through each row in the array
            {
                for (int col = 0; col < 3; col++) // iterate through each column in the row
                {
                    Console.Write($" {moves[row, col]} "); // write the move in that position of the array
                    if (col < 2) Console.Write("|"); // column separator
                }
                Console.WriteLine(); // finish the line for the row once all columns are printed out
                if (row < 2) Console.WriteLine("---+---+---"); // row separator
            }
        }
    }
}
