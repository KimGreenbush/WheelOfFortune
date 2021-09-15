using Microsoft.VisualStudio.TestTools.UnitTesting;
using Wheel_Of_Fortune;
using Moq;

namespace Wheel_Of_Fortune_Testing
{
    [TestClass]
    public class GuessTests
    {
        string samplePuzzleNoSpaces = "Word";
        string samplePuzzleWithSpaces = "Some words";
        string correctSampleLetter = "w";
        string incorrectSampleLetter = "a";
        string integerAsString = "1";

        [TestMethod]
        public void TestGuessIsAlpha()
        {
            //Arrange
            // need a sample puzzle, sring int

            // Act

            // Assert
        }

        [TestMethod]
        public void TestGuessLetterNoSpaces()
        {
            //Arrange
            // need a sample puzzle, letter
            // must not be string int


            // Act

            // Assert
        }

        [TestMethod]
        public void TestSolvePuzzleNoSpaces()
        {
            //Arrange
            // need a sample puzzle, solution
            // must not be string int

            // Act

            // Assert
        }

        [TestMethod]
        public void TestGuessLetterWithSpaces()
        {
            //Arrange
            // need a sample puzzle, letter
            // must not be string int

            // Act

            // Assert
        }

        [TestMethod]
        public void TestSolvePuzzleWithSpaces()
        {
            //Arrange
            // need a sample puzzle, solution
            // must not be string int

            // Act

            // Assert
        }
    }
}
