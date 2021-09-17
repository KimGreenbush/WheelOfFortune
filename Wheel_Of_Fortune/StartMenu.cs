using System;
using static System.Console;

namespace Wheel_Of_Fortune
{
    /// <summary>
    /// This class is responsible for greeting a player and providing instructions.
    /// </summary>
    public class StartMenu    
    {
        private static string GetGameIntroGreeting() => "********** Welcome to Wheel of Fortune ***********";

        public static string GetGameInstructions() => "Instructions: A player guesses letters until they until they are able to solve the puzzle...";

        public void GetGameStartDisplay()
        {
            string greeting = GetGameIntroGreeting();
            WriteLine($"\n {greeting}");

            string instructions = GetGameInstructions();
            WriteLine($"\n {instructions}");
        }
    }
}