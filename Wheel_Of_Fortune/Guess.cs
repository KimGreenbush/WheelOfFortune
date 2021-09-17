using System;
using System.Text.RegularExpressions;

namespace Wheel_Of_Fortune
{
    public static class Guess
    {
        private static bool isCorrect = false;
        private static bool isAlpha = false;

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
        /// Takes an input string one character long to pass to the Puzzle for comparison.
        /// </summary>
        /// <param name="letter">A string of only one character.</param>
        /// <exception cref="ArgumentException">Throws an ArugmentException if the letter is not an alpha character.</exception>
        /// <returns> <see cref="bool">true</see> if the letter is a match, or <see cref="bool">false</see></returns>
        /// 
        public static bool GuessLetter(string letter)
        {
            isAlpha = IsAlpha( letter );
            if ( !isAlpha )
            {
                throw new ArgumentException( "Guess should only be a letter." );
            }
            else
            {
                // need to implement
                letter.ToLower();
                // isCorrect = Puzzle.CheckLetter( letter );
            }
            return isCorrect;
        }

        /// <summary>
        /// Takes an input string longer than one character to pass to the Puzzle for comparison.
        /// </summary>
        /// <param name="attemptedSolution">A string of more than one character.</param>
        /// <exception cref="ArgumentException">Throws an ArugmentException if any letters are not an alpha character.</exception>
        /// <returns> <see cref="bool">true</see> if the string is a match, or <see cref="bool">false</see></returns>
        /// 
        public static bool SolvePuzzle(string attemptedSolution)
        {
            isAlpha = IsAlpha( attemptedSolution );
            if ( !isAlpha )
            {
                throw new ArgumentException( "Guess should only contain letters." );
            }
            else
            {
                // need to implement
                attemptedSolution.ToLower();
                // isCorrect = Puzzle.SolvePuzzle( string );
            }
            return isCorrect;
        }
    }
}