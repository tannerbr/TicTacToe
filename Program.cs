using TicTacToe;

// Welcome User
Console.WriteLine("Welcome to Tic-Tac-Toe!");

// Create game board
char[,] gameBoard = new char[3, 3];

// Initialize game board with empty spaces
InitializeGameBoard(gameBoard);

// Create an instance of the finalBoard object
Support finalBoard = new Support();

// Main game loop
bool gameWon = false;
int turn = 0;
char currentPlayer = 'X';
string response = "";

// Loop through game while the game is not won and less than 9 turns
while (!gameWon && turn < 9)
{
    // Calling the method to print the board
    finalBoard.printBoard(gameBoard);
    Console.WriteLine($"Player {currentPlayer}, enter your move (row 1-3 and column 1-3): ");

    // Read and validate row input
    int row = -1;
    
    // While loop to validate user input 
    while (row < 0 || row > 2)
    {
        string rowInput = Console.ReadLine();
        
        // Have the length of rows be 3
        if (int.TryParse(rowInput, out row) && row >= 1 && row <= 3)
        {
            row--;  // Adjust for 0-based index
            break;
        }
        else
        {
            Console.WriteLine("Invalid input for row. Please enter a number between 1 and 3.");
        }
    }
    
    // Read and validate column input
    int col = -1;
    
    // While loop to go through columns 1-3
    while (col < 0 || col > 2)
    {
        string colInput = Console.ReadLine();
        if (int.TryParse(colInput, out col) && col >= 1 && col <= 3)
        {
            col--;  // Adjust for 0-based index
            break;
        }
        else
        {
            Console.WriteLine("Invalid input for column. Please enter a number between 1 and 3.");
        }
    }

    // Check if the chosen spot is empty
    if (gameBoard[row, col] == ' ')
    {
        // Place the player's move on the board
        gameBoard[row, col] = currentPlayer;
        turn++;

        // Check if there's a winner after this move
        (response, gameWon) = finalBoard.CheckForWinner(gameBoard);
        
        // If the game is won then print the message
        if (gameWon)
        {
            finalBoard.printBoard(gameBoard);
            Console.WriteLine($"Player {currentPlayer} wins!");
        }
        // Switch players
        else
        {
            currentPlayer = currentPlayer == 'X' ? 'O' : 'X';
        }
    }
    else
    {
        Console.WriteLine("Invalid move. The chosen spot is already taken. Try again.");
    }
}

// If the game is a tie
if (!gameWon)
{
    // Calling the method
    finalBoard.printBoard(gameBoard);
    Console.WriteLine("It's a tie!");
}
// Method making the board 
static void InitializeGameBoard(char[,] board)
{
    // Loop to go through each row
    for (int row = 0; row < 3; row++)
    {
        // Loop to go through each column
        for (int col = 0; col < 3; col++)
        {
            // Having the row and column be empty
            board[row, col] = ' ';
        }
    }
}




