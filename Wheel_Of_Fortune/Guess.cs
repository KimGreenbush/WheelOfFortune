using System;
using System.Collections.Generic;
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
            return isOnlyLetters;

        }

        /// <summary>
        /// Takes a letter to pass to the Puzzle for comparison.
        /// </summary>
        /// <param name="letter">A string of only one character.</param>
        /// <paramref name="letter"/>
        /// <exception cref="ArgumentException">Throws an ArugmentException if the letter is not an alpha character.</exception>
        /// <returns> <see cref="bool">true</see> if the letter is a match, or <see cref="bool">false</see> </returns>s
        /// 
        public static bool GuessLetter(string letter)
        {
            bool isAlpha = IsAlpha( letter );
            bool isCorrect = false;
            if ( !isAlpha )
            {
                throw new ArgumentException( "Guess should only be a letter." );
            }
            else
            {
                // isCorrect = Puzzle.CheckLetter( string );
            }
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