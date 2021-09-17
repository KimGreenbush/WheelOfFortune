using Microsoft.VisualStudio.TestTools.UnitTesting;
using Wheel_Of_Fortune;

namespace Wheel_Of_Fortune_Testing
{
    [TestClass]
    public class PuzzleControllerTest
    {
        [TestMethod]
        public void GetPuzzleObject_FirstGuess_HappyCase()
        {
            // Arrange
            PuzzleController puzzle = PuzzleController.GetInstance();
            puzzle.GeneratePuzzle(0);
            puzzle.CheckLetter("j");

            // Act
            PuzzleObject result = puzzle.GetPuzzleObject();

            // Assert
            Assert.AreEqual("steady run", result.hint);
            Assert.AreEqual("j##", result.currentStatusPuzzle);
            Assert.AreEqual("j", result.guessedLetter);

        }

        [TestMethod]
        public void GetPuzzleObject_FirstGuessWrong_HappyCase()
        {
            // Arrange
            PuzzleController puzzle = PuzzleController.GetInstance();
            puzzle.GeneratePuzzle(0);
            puzzle.CheckLetter("r");

            // Act
            PuzzleObject result = puzzle.GetPuzzleObject();

            // Assert
            Assert.AreEqual("steady run", result.hint);
            Assert.AreEqual("###", result.currentStatusPuzzle);
            Assert.AreEqual("r", result.guessedLetter);

        }

        [TestMethod]
        public void CheckLetter_FirstGuessCorrect_HappyCase()
        {
            // Arrange
            PuzzleController puzzle = PuzzleController.GetInstance();
            puzzle.GeneratePuzzle(0);


            // Act
            bool result = puzzle.CheckLetter("j");

            // Assert
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void CheckLetter_FirstGuessWrong_HappyCase()
        {
            // Arrange
            PuzzleController puzzle = PuzzleController.GetInstance();
            puzzle.GeneratePuzzle(0);

            // Act
            bool result = puzzle.CheckLetter("r");

            // Assert
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void CheckLetter_CheckException_ThrowAgrumentException()
        {
            // Arrange
            PuzzleController puzzle = PuzzleController.GetInstance();
            puzzle.GeneratePuzzle(0);

            // Act
            try
            {
                bool result = puzzle.CheckLetter("re");
            }
            catch (System.ArgumentException ex)
            {
                Assert.AreEqual("invalid letter (Parameter 'letter')", ex.Message);
                Assert.AreEqual("letter", ex.ParamName);
            }
            catch (System.Exception ex)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void SolveProblem_GuessCorrect_HappyCase()
        {
            // Arrange
            PuzzleController puzzle = PuzzleController.GetInstance();
            puzzle.GeneratePuzzle(0);


            // Act
            bool result = puzzle.SolveProblem("jog");

            // Assert
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void SolveProblem_GuessWrong_HappyCase()
        {
            // Arrange
            PuzzleController puzzle = PuzzleController.GetInstance();
            puzzle.GeneratePuzzle(0);


            // Act
            bool result = puzzle.SolveProblem("fog");

            // Assert
            Assert.AreEqual(false, result);
        }
    }
}
