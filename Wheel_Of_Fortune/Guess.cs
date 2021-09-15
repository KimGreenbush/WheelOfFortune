using System;
using System.Text.RegularExpressions;

namespace Wheel_Of_Fortune
{
    public static class Guess : IGuess
    {
        bool isAlpha(string guess)
        {
            return Regex.IsMatch( guess, @"^[a-zA-Z]+$" );
        }

        public void GuessLetter(string letter)
        {
            // pass letter to Puzzle => return bool
            // true print "Correct letter"
            // false print "Incorrect letter"
        }

        public void SolvePuzzle(string attemptedSolution)
        {
            // pass attemptedSolution to Puzzle => return bool
            // true print "Correct! You win!"
            // false print "Incorrect solution"
        }
    }

    public interface IGuess
    {
        public void GuessLetter(string value) { }
        public void SolvePuzzle(string value) { }
    }
}