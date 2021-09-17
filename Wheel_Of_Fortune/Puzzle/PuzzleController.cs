using System;
using System.Collections;
using System.Linq;

namespace Wheel_Of_Fortune
{
    public class PuzzleController
    {
        private Puzzle[] puzzles;
        private string currPuzzle;
        private char[] currStatusPuzzleArr;
        private ArrayList guessedLetterArr;
        private int index = -1;

        // PuzzleController obj = PuzzleController.GetInstance()
        // Create new object
        public static PuzzleController obj;

        public static PuzzleController GetInstance()
        {
            if (obj == null)
            {
                obj = new PuzzleController();
            }
            return obj;
        }

        // Build contructor
        private PuzzleController()
        {
            puzzles = new Puzzle[2];
            puzzles[0] = new Puzzle("jog", "Steady run");
            puzzles[1] = new Puzzle("read", "an action");
        }

        // Create new puzzle
        public void GeneratePuzzle()
        {
            GeneratePuzzle(index++);
        }

        // For unit test purpose
        public void GeneratePuzzle(int index)
        {
            this.index = index;
            // Initial current puzzle
            currPuzzle = puzzles[index].puzzle;
            // Create a display hidden puzzle
            currStatusPuzzleArr = new char[currPuzzle.Length];
            GenerateFirstDisplayedPuzzle();
            guessedLetterArr = new ArrayList();
        }

        // Create and Return PuzzleObject to controller
        public PuzzleObject GetPuzzleObject()
        {
            string currStatusPuzzleString = (new String(currStatusPuzzleArr)).ToLower();

            // Cast arraylist to string array and then join the string array to string
            string[] guessedLetterArray = guessedLetterArr.Cast<string>().ToArray();
            string guessedLetterString = string.Join(", ", guessedLetterArray).ToLower();
 
            return new PuzzleObject(puzzles[index].hint, currStatusPuzzleString, guessedLetterString);
        }

        // Checking Letter is in puzzle or not
        public bool CheckLetter(string letter)
        {
            if (letter.Length > 1)
            {
                throw new ArgumentException("invalid letter", "letter");
            }
            bool containsLetter = currPuzzle.Contains(letter);
            SetGuessedLetters(letter);
            if (containsLetter)
            {
                SetCurrenStatusPuzzle(letter);
            }
            return containsLetter;
        }

        // Checking the word player entered is puzzle or not
        public bool SolveProblem(string guessedPuzzle)
        {
            return currPuzzle.Equals(guessedPuzzle);
        }

        // Generate the first displayed puzzle (contain all # symbols)
        private void GenerateFirstDisplayedPuzzle()
        {
            for (int i = 0; i < currPuzzle.Length; i++)
            {
                if (currPuzzle[i] != ' ')
                {
                    currStatusPuzzleArr[i] = '#';
                }
            }
        }


        // Update the current status of puzzle, which will be displayed on the console
        private void SetCurrenStatusPuzzle(string letter)
        {
            string puzzle = currPuzzle;
            int length = puzzle.Length;
            for (int i = 0; i < length; i++)
            {
                if (puzzle[i] == letter[0])
                {
                    currStatusPuzzleArr[i] = letter[0];
                }
            }
        }

        // Update the string of guessed letters
        private void SetGuessedLetters(string letter)
        {
            guessedLetterArr.Add(letter);
        }
    }
}
