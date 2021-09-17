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

        //[DataTestMethod]
        //[DataRow( "A" )]
        //[DataRow( "a" )]
        //public void TestGuessLetterReturnsTrueIfInPuzzle(string letter)
        //{
            //Arrange
         //   bool guess = false;

            // Act
            // guess = Guess.GuessLetter( letter );

         //   // Assert
         //   Assert.IsTrue(guess, "Passed letter failed comparison check.");
        //}

        [DataTestMethod]
        [DataRow( "." )]
        [DataRow( "1" )]
        public void TestGuessLetterReturnsErrorIfPassedInvalidGuess( string letter )
        {
            // Assert
            Assert.ThrowsException<ArgumentException>(
                () => Guess.GuessLetter( letter ), 
                "Guess was not an alpha character (letter)");
        }


        //[DataTestMethod]
        //[DataRow( "A" )]
        //[DataRow( "a" )]
        //public void TestSolvePuzzleReturnsTrueIfGuessMatches(string value)
        //{
        //Arrange
        // need a sample puzzle, solution
        // must not be string int

        // Act

        // Assert
        // }
    }
}
