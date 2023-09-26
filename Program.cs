/* Guess the number
 *   - Will need to Randomly generate a number between 1-20
 *   - Read user input
 *   - State if the guess is high or low
 *   - Dificulty levels?
 *   - Give x chances (where x = difficulty)
 *          - If the guess is correct, end the game with Win con
 *          - If the number is incorrect, keep going until guesses are up. 
 *          
 */
Random random = new Random();

int numToGuess = 0;
string playerGuess;
int guesses = 3;
int playerGuessNum;
bool isPlaying = true;




Difficulty();

while(isPlaying == true)
{
    Game();
}

// Method that contains the core Game.
void Game()
{
    for (int i = guesses; i > 0; i--)
    {
        Console.WriteLine("\nWhat is your guess: ");
        playerGuess = Console.ReadLine();

        while (!int.TryParse(playerGuess, out playerGuessNum))
        {
            Console.WriteLine("That is not a valid number. Please guess again: ");
            playerGuess = Console.ReadLine();
        }
        if (playerGuessNum == numToGuess)
        {
            Console.WriteLine("That is correct!\n");
            i = 0;
        }
        else
        {
            if (i == 1)
            {
                Console.WriteLine("Good Try, better luck next time!");
            }
            else if (playerGuessNum > numToGuess)
            {
                Console.WriteLine("That number is too high, please try again\n");
            }
            else
            {
                Console.WriteLine("That number is too low, please try again\n");
            }
        }
    }
    Console.WriteLine("Keep Playing? type 'y' for yes and any other key to stop playing.");

    if (Console.ReadKey().Key == ConsoleKey.Y)
    {
        isPlaying = true;
        Console.WriteLine("\n\n");
    }
    else
    {
        isPlaying = false;
    }
}

//Method that allows you to choose the difficulty of your game.
void Difficulty()
{
    {
        string difficulty;
        int difficultyNum;

        // Choose Difficulty
        Console.WriteLine("What difficulty did you want to play on?\n   1. Hard\n   2. Medium\n   3. Easy");
        difficulty = Console.ReadLine();

        while (!int.TryParse(difficulty, out difficultyNum))
        {
            Console.WriteLine("That is not a valid level, please select 1, 2, or 3.");
            playerGuess = Console.ReadLine();
        }
        if (difficultyNum == 1)
        {
            numToGuess = random.Next(1, 100);
            guesses = 7;
        }
        else if (difficultyNum == 2)
        {
            numToGuess = random.Next(1, 50);
            guesses = 5;
        }
        else if (difficultyNum == 3)
        {
            numToGuess = random.Next(1, 20);
            guesses = 7;
        }
    }
}