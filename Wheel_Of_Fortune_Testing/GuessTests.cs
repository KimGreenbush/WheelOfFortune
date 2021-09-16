using System;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Wheel_Of_Fortune;
using Moq;

namespace Wheel_Of_Fortune_Testing
{
    [TestClass]
    public class GuessTests
    {
        // string samplePuzzleNoSpaces = "Word";
        // string samplePuzzleWithSpaces = "Some words";
        // string correctSampleLetter = "w";
        // string incorrectSampleLetter = "a";

        [DataTestMethod]
        [DataRow("1")]
        [DataRow(".")]
        public void TestGuessIsNotAlpha(string value)
        {
            bool isALetter = Regex.IsMatch( value, @"^[a-zA-Z]+$" );
            Assert.IsFalse( isALetter, "Input should not accept non-characters as letters." );
        }

        [TestMethod]
        public void TestGuessIsAlpha()
        {
            bool isALetter = Regex.IsMatch( "a", @"^[a-zA-Z]+$" );
            Assert.IsTrue( isALetter, "Input should only contain letters." );
        }

        [TestMethod]
        public void TestGuessLetter()
        {
            //Arrange
            // need a sample puzzle, letter
            // must not be string int

            // Act

            // Assert
        }


        //[TestMethod]
        //public void TestSolvePuzzleNoSpaces()
        //{
            //Arrange
            // need a sample puzzle, solution
            // must not be string int

            // Act

            // Assert
       // }
    }
}
