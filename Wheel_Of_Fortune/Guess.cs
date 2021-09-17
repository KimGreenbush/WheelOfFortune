using System;
using System.Collections.Generic;
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
        /// Takes a letter to pass to the Puzzle for comparison.
        /// </summary>
        /// <param name="letter">A string of only one character.</param>
        /// <paramref name="letter"/>
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
                // isCorrect = Puzzle.CheckLetter( string );
            }
            return isCorrect;
        }

        /// <summary>
        /// Takes a string longer than one letter to pass to the Puzzle for comparison.
        /// </summary>
        /// <param name="attemptedSolution">A string of more than one character.</param>
        /// <paramref name="attemptedSolution"/>
        /// <exception cref="ArgumentException">Throws an ArugmentException if any letters are not an alpha character.</exception>
        /// <returns> <see cref="bool">true</see> if the letter is a match, or <see cref="bool">false</see></returns>
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
                // isCorrect = Puzzle.SolvePuzzle( string );
            }
            return isCorrect;
        }
    }
}