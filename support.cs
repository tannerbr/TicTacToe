using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TicTacToe
{
    internal class Support
    {

        public void printBoard(char[,] moves)
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
        
        public (string, bool) CheckForWinner(char[,] board)
        {
            string response = "";
            bool endGame = false;
            for (int row = 0; row < 3; row++)
            {
                if (board[row, 0] == board[row, 1] && board[row, 1] == board[row, 2] && board[row, 0] != ' ')
                {
                    response = $"Player {board[row, 0]} has won!"; // Winner is either 'X' or 'O'
                    endGame = true;
                }
            } 
            // Check columns
            for (int col = 0; col < 3; col++)
            {
                if (board[0, col] == board[1, col] && board[1, col] == board[2, col] && board[0, col] != ' ')
                {
                    response = $"Player {board[0, col]} has won!"; // Winner is either 'X' or 'O'
                    endGame = true;
                }
            }
            // Check diagonals
            if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2] && board[0, 0] != ' ')
            {
                response = $"Player {board[0, 0]} has won!"; // Winner is either 'X' or 'O'
                endGame = true;
            }

            if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0] && board[0, 2] != ' ')
            {
                response = $"Player {board[0, 2]} has won!"; // Winner is either 'X' or 'O'
                endGame = true;
            }
            // Check for a tie (if there is no winner and the board is full)
            if (endGame == false)
            {
                bool boardFull = true;

                // Loop through the board to check if any spaces are empty
                for (int row = 0; row < 3; row++)
                {
                    for (int col = 0; col < 3; col++)
                    {
                        if (board[row, col] == ' ') // Found an empty space
                        {
                            boardFull = false;
                            break; // No need to check further
                        }
                    }
                    if (!boardFull) break; // If found empty space, exit the row loop
                }

                if (boardFull)
                {
                    response = "It's a tie!";
                    endGame = true;
                }
            }
            // No winner yet
            return (response, endGame); 
        }
        
        }
    }





