using System;
using System.Text.RegularExpressions;

namespace Wheel_Of_Fortune
{
    public abstract class Guess
    {
        private static readonly PuzzleController puzzle = PuzzleController.GetInstance();
        private bool isCorrect = false;
        private bool isAlpha = false;

        /// <summary>
        /// Checks that the input value only contains alpha characters (letters).
        /// </summary>
        /// <param name="guess"></param>
        /// <returns></returns>
        bool IsAlpha(string guess)
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
        public bool GuessLetter(string letter)
        {
            isAlpha = IsAlpha( letter );
            if ( !isAlpha )
            {
                throw new ArgumentException( "Guess should only be a letter." );
            }
            else
            {
                letter.ToLower();
                isCorrect = puzzle.CheckLetter( letter );
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
        public bool SolvePuzzle(string attemptedSolution)
        {
            isAlpha = IsAlpha( attemptedSolution );
            if ( !isAlpha )
            {
                throw new ArgumentException( "Guess should only contain letters." );
            }
            else
            {
                attemptedSolution.ToLower();
                isCorrect = puzzle.SolveProblem( attemptedSolution );
            }
            return isCorrect;
        }
    }
}