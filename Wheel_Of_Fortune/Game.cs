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
            menu.GetGameStartDisplay();
            ContinueGame();
        }

        /// <summary>
        /// (Important) This method is called on each turn a player takes. If a player solves the puzzle,
        /// or quits the game, this method will no longer be called and the game will be terminated.
        /// </summary>
        public void ContinueGame()
        {
            TurnOptions options = new TurnOptions();

            /*
             * NOTE: This comes from Tracy method "GetPuzzleObject()" that returns an object.
             * display Hint
             * display Puzzle
             * display Previously Guessed Letters
            */

            // Displays a users turn options
            WriteLine(options.GetPlayerOptions());

            // Users choice on how to proceed
            string playerEntry = ReadLine();

            // Based on a users selection, the relevant methods will display next steps
            // and then capture the players guess/solve entries
            options.HandlePlayerSelection(playerEntry);
        }

        /// <summary>
        /// This method alerts a player of their win, and will either end the game at this time
        /// or offer players another chance to play the game.
        /// </summary>
        public void PlayerWinsGame()
        {
            WriteLine("YOU WIN... You solved the puzzle");
            // TODO: Add new set of options (where to go from here)
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

