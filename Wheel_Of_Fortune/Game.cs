using System;
using static System.Console;

namespace Wheel_Of_Fortune
{
    public class Game
    {
        /// <summary>
        /// This method begins the game by displaying a greeting, the instructions to the game, and by 
        /// triggering the "game loop" function that continues to call on itself respective player turn.
        /// </summary>
        public void StartGame()
        {
            StartMenu menu = new StartMenu();
            // TODO: Call GeneratePuzzle();
            Console.ForegroundColor = ConsoleColor.Blue;
            menu.GetGameStartDisplay();
            Console.ForegroundColor = ConsoleColor.White;
            ContinueGame();
        }

        /// <summary>
        /// (Important) This method is called on each turn a player takes. If a player solves the puzzle,
        /// or quits the game, this method will no longer be called and the game will be terminated.
        /// </summary>
        public void ContinueGame()
        {
            TurnOptions options = new TurnOptions();

            // Displays hint, puzzle, and previously guessed letters
            DisplayGamePuzzle();

            // Displays a users turn options
            WriteLine(options.GetPlayerOptions());

            // Users choice on how to proceed
            // TODO: Error Handling
            string playerEntry = ReadLine();

            // Based on a users selection, the relevant methods will display next steps
            // and then capture the players guess/solve entries
            options.HandlePlayerSelection(playerEntry);
        }

        /// <summary>
        /// Dipslays the puzzle hint, the puzzle itselft, and all previously guessed letters.
        /// </summary>
        public void DisplayGamePuzzle()
        {
            PuzzleController obj = PuzzleController.GetInstance();
            var puzzleObj = obj.GetPuzzleObject();

            string hint = puzzleObj.hint;
            string currentStatusPuzzle = puzzleObj.currentStatusPuzzle;
            string guessedLetter = puzzleObj.guessedLetter;

            Console.ForegroundColor = ConsoleColor.Yellow;
            WriteLine($"\nHINT: {hint}");
            WriteLine($"\nPUZZLE: {currentStatusPuzzle}");
            WriteLine($"\nGUESSED LETTERS: {guessedLetter}");
            Console.ForegroundColor = ConsoleColor.White;
        }

        /// <summary>
        /// This method alerts a player of their win, and will either end the game at this time
        /// or offer players another chance to play the game.
        /// </summary>
        public void PlayerWinsGame()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            WriteLine("\nYOU WIN... You solved the puzzle");
            // TODO: Add new set of options (where to go from here)
            Console.ForegroundColor = ConsoleColor.White;
        }

        /// <summary>
        /// This method alerts a player of their loss, and will either end the game at this time
        /// or offer players another chance to play the game.
        /// </summary>
        public void PlayerLosesGame()
        {
            WriteLine("YOU LOSE... Better off next time.");
            // TODO: Add new set of options (where to go from here)
        }

        /// <summary>
        /// This ends game immediately, and clears console.
        /// </summary>
        public void QuitGame()
        {
            Clear();
        }
    }
}

