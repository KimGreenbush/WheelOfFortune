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
        /// This method is called on each turn taken by a player. If a player solves the puzzle,
        /// or quits the game, this method will no longer be called and the game will be terminated.
        /// </summary>
        public void ContinueGame()
        {
            TurnOptions options = new TurnOptions();

            // This comes from Tracy object "GetPuzzleObject" (Maybe have a display method fo rhtis.
            // display Hint
            // display Puzzle
            // display Guessed Letters
            // display NextOptions

            options.GetPlayerOptions();
            string playerEntry = ReadLine();
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

        public void QuitGame()
        {
            Clear();
        }
    }
}





















//using System;
//using static System.Console;

//namespace Wheel_Of_Fortune
//{
//    public class Game
//    {
//        public string GetGameIntroGreeting() => "********** Welcome to Wheel of Fortune ***********";

//        public string GetGameInstructions() => "Instructions: A player guesses letters until they choose to solve the puzzle...";

//        public void StartGame()
//        {
//            string greeting = this.GetGameIntroGreeting();
//            WriteLine($"\n {greeting}");

//            string instructions = this.GetGameInstructions();
//            WriteLine($"\n {instructions}");

//            PlayFirstRound();
//        }

//        public void PlayFirstRound()
//        {
//            // display Hint

//            // display Puzzle

//            // display Guessed Letters

//            // display NextOptions
//        }

//        public void PlayNextRound()
//        {

//        }

//        public void PlayerWins()
//        {
//            WriteLine("YOU WIN... You solved the puzzle");
//            // TODO: Add new set of options (where to go from here)
//        }

//        public void PlayerLoses()
//        {
//            WriteLine("YOU LOSE... Better off next time.");
//            // TODO: Add new set of options (where to go from here)
//        }


//        public void QuitGame() { }
//    }
//}