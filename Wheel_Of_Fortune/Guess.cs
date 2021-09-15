using System;

namespace Wheel_Of_Fortune
{
    public static class Guess : IGuess
    {
        public void GuessLetter(string letter)
        {
            // pass letter to Puzzle => return string letter
            // true print "Correct letter"
            // false print "Incorrect letter"
        }

        public void SolvePuzzle(string attemptedSolution)
        {
            // pass attemptedSolution to Puzzle => return string attemptedSolution
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