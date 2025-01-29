// Welcome User
Console.WriteLine("Welcome to Tic-Tac-Toe!");

// Create game board
char[,] gameBoard = new char[3, 3];

// Initialize game board with empty spaces
InitializeGameBoard(gameBoard);

// Main game loop
bool gameWon = false;
int turn = 0;
char currentPlayer = 'X';

while (!gameWon && turn < 9)
{
    PrintGameBoard(gameBoard);
    Console.WriteLine($"Player {currentPlayer}, enter your move (row and column): ");
    int row = int.Parse(Console.ReadLine());
    int col = int.Parse(Console.ReadLine());

    if (gameBoard[row, col] == ' ')
    {
        gameBoard[row, col] = currentPlayer;
        turn++;
        gameWon = CheckForWinner(gameBoard);

        if (gameWon)
        {
            PrintGameBoard(gameBoard);
            Console.WriteLine($"Player {currentPlayer} wins!");
        }
        else
        {
            currentPlayer = currentPlayer == 'X' ? 'O' : 'X';
        }
    }
    else
    {
        Console.WriteLine("Invalid move. Try again.");
    }
}

if (!gameWon)
{
    PrintGameBoard(gameBoard);
    Console.WriteLine("It's a tie!");
}

        static void InitializeGameBoard(char[,] board)
{
    for (int row = 0; row < 3; row++)
    {
        for (int col = 0; col < 3; col++)
        {
            board[row, col] = ' ';
        }
    }
}

static void PrintGameBoard(char[,] board)
{
    for (int row = 0; row < 3; row++)
    {
        for (int col = 0; col < 3; col++)
        {
            Console.Write(board[row, col]);
            if (col < 2) Console.Write("|");
        }
        Console.WriteLine();
        if (row < 2) Console.WriteLine("-----");
    }
}

static bool CheckForWinner(char[,] board)
{
    // Check rows, columns, and diagonals for a winner
    for (int i = 0; i < 3; i++)
    {
        if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2] && board[i, 0] != ' ')
            return true;
        if (board[0, i] == board[1, i] && board[1, i] == board[2, i] && board[0, i] != ' ')
            return true;
    }

    if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2] && board[0, 0] != ' ')
        return true;
    if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0] && board[0, 2] != ' ')
        return true;

    return false;
}




