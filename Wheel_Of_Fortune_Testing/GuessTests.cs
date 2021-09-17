using System;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Wheel_Of_Fortune;

namespace Wheel_Of_Fortune_Testing
{
    [TestClass]
    public class GuessTests
    {
        [DataTestMethod]
        [DataRow("1")]
        [DataRow(".")]
        public void TestGuessIsNotAlpha(string value)
        {
            bool isALetter = Regex.IsMatch( value, @"^[a-zA-Z]+$" );
            Assert.IsFalse( isALetter, "Input should not accept non-characters as letters." );
        }

        [DataTestMethod]
        [DataRow( "j" )]
        [DataRow( "o" )]
        public void TestGuessLetterReturnsTrueIfInPuzzle(string letter)
        {
            bool guess = Guess.GuessLetter( letter );

            Assert.IsTrue(guess, "Passed letter failed comparison check.");
        }

        [DataTestMethod]
        [DataRow( "." )]
        [DataRow( "1" )]
        public void TestGuessLetterReturnsErrorIfPassedInvalidGuess( string letter )
        {
            Assert.ThrowsException<ArgumentException>(
                () => Guess.GuessLetter( letter ), 
                "Guess was not an alpha character (letter)");
        }

        [TestMethod]
        public void TestSolvePuzzleReturnsTrueIfGuessMatches()
        {
            bool guess = Guess.SolvePuzzle( "jog" );

            Assert.IsTrue( guess, "Passed solution failed comparison check." );
        }

        [DataTestMethod]
        [DataRow( "READ." )]
        [DataRow( "123" )]
        public void TestSolvePuzzleReturnsErrorIfPassedInvalidGuess( string word )
        {
            // Assert
            Assert.ThrowsException<ArgumentException>(
                () => Guess.SolvePuzzle( word ),
                "Guess contained non-alpha characters (letters)" );
        }
    }
}
