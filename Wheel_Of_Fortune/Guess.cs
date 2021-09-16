using System;
using System.Text.RegularExpressions;

namespace Wheel_Of_Fortune
{
    public static class Guess
    {
        private static bool isCorrect = false;

        /// <summary>
        /// Checks that the input value only contains alpha characters (letters).
        /// </summary>
        /// <param name="guess"></param>
        /// <returns></returns>
        static bool IsAlpha(string guess)
        {
            bool isOnlyLetters = Regex.IsMatch( guess, @"^[a-zA-Z]+$" );

            if ( !isOnlyLetters )
            {
                throw new Exception( "Guess should only contain letters." );
            }
            return isOnlyLetters;
          
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="letter"></param>
        /// <returns></returns>
        public static bool GuessLetter(string letter)
        {
            // check isAlpha
            // pass letter to Puzzle CheckLetter(string) => return bool
            // true print "Correct letter"
            // false print "Incorrect letter"
            // isCorrect = response from Puzzle
            return isCorrect;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="attemptedSolution"></param>
        /// <returns></returns>
        public static bool SolvePuzzle(string attemptedSolution)
        {
            // check isAlpha
            // pass attemptedSolution to Puzzle SolveProblem(string) => return bool
            // true print "Correct! You win!"
            // false print "Incorrect solution"
            // isCorrect = response from Puzzle
            return isCorrect;
        }
    }
}