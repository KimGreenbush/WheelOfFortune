using System;
using static System.Console;

namespace Wheel_Of_Fortune
{
    class GuessOptions
    {
        /// <summary>
        /// Displays instructions on how to guess a letter, captures the user input,
        /// and sends the input off to be checked against the puzzle.
        /// </summary>
        /// <returns>A boolean signaling whether or not the puzzle includes a given letter.</returns>
        public bool GetChooseLetterOptions()
        {
            WriteLine("\nPlease choose a letter between A - Z, and then press ENTER");
            string playerEntry = ReadLine().ToLower();

            // IMPORTANT TODO: Need to add error handling for incorrect key entries
            // bool guessedCorrectly = GuessLetter(playerEntry);
            // return guessedCorrectly;
            return false;
        }

        /// <summary>
        /// Displays instructions on how to solve the puzzle, captures the user input,
        /// and sends the input to be checked against the current puzzle.
        /// </summary>
        /// <returns>A boolean that signals if a user has correctly solved the puzzle.</returns>
        public bool GetSolvePuzzleOptions()
        {
            WriteLine("\nYou may solve the puzzle at this time, and then press ENTER");
            string playerEntry = ReadLine();

            // IMPORTANT TODO: Need to add error handling for incorrect key entries
            // bool guessedCorrectly = SolvePuzzle(playerEntry);
            // return guessedCorrectly;
            return true;  
        }
    }
}