using System;
using static System.Console;

namespace Wheel_Of_Fortune
{
    class TurnOptions
    {
        /// <summary>
        /// Provides a list of options that will be logged to the console, allowing a player to make choices
        /// about how they want to proceed with the game.
        /// </summary>
        /// <returns></returns>
        public string GetPlayerOptions() => "\n Press 1 to guess a letter \n Press 2 to solve the puzzle \n Press 3 to quite the game \n";

        /// <summary>
        /// This routes a users entry to it's respective method. A switch statement is utilized to route
        /// a player to the "guess a letter" options, to "solve the puzzle options, or a third option of
        /// quitting and ending the game when a player chooses.
        /// </summary>
        /// <param name="userEntry"></param>
        public void HandlePlayerSelection(string userEntry)
        {
            GuessOptions options = new GuessOptions();
            Game game = new Game();
            bool isCorrectGuess;

            // "Cleans" console of previosly displayed items before displaying next items
            Clear();

            switch (userEntry)
            {
                case "1":
                    isCorrectGuess = options.GetChooseLetterOptions();
                    if (isCorrectGuess)
                    {
                        Clear();
                        WriteLine("\nGood job! You guessed correctly. Here is the updated puzzle.");
                        game.ContinueGame();
                    }
                    else
                    {
                        Clear();
                        WriteLine("\nIncorrect entry! Please continue the game");
                        game.ContinueGame();
                    }
                    break;

                case "2":
                    isCorrectGuess = options.GetSolvePuzzleOptions();
                    if (isCorrectGuess)
                    {
                        game.PlayerWinsGame();
                    }
                    else
                    {
                        Clear();
                        WriteLine("\nIncorrect entry! Please continue the game");
                        game.ContinueGame();
                    }
                    break;

                case "3":
                    WriteLine("Goodbye!");
                    game.QuitGame();
                    break;

                default:
                    WriteLine("Current default statement in switch");
                    // TODO: Error handling 
                    game.ContinueGame();
                    break;
            } 
        }
    }
}
