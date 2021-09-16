using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Wheel_Of_Fortune.Puzzle;

namespace Wheel_Of_Fortune
{
    class PuzzleController
    {
        private Puzzle[] puzzles;
        private string currPuzzle;
        private char[] currStatusPuzzle;
        ArrayList guessedLetter = new ArrayList();

        public PuzzleController()
        {
            this.puzzles = new Puzzle[2];
            this.puzzles[0] = new Puzzle("jog", "Steady run");
            this.puzzles[1] = new Puzzle("read", "an action");
        }

        // Create new puzzle
        public Puzzle CreatePuzzle()
        {
            // Create a random puzzle
            Random rand = new Random();
            int num = rand.Next(0, puzzles.Length);
            // Initial current puzzle
            currPuzzle = puzzles[num].puzzle;
            // Create a display hidden puzzle
            GenerateFirstDisplayedPuzzle();

            return puzzles[num];
        }


        public bool CheckLetter(string letter)
        {
            bool containsLetter = currPuzzle.Contains(letter);
            GetGuessedLetters(letter);
            if (containsLetter)
            {
                GetCurrenStatusPuzzle(letter);
            }
            return containsLetter;
        }

        public bool SolveProblem(string guessedPuzzle)
        {
            return currPuzzle.Equals(guessedPuzzle);
        }

        // Generate the first time displayed puzzle
        private void GenerateFirstDisplayedPuzzle()
        {
            string puzzleRandom = currPuzzle;

            for (int i = 0; i < puzzleRandom.Length; i++)
            {
                if (puzzleRandom[i] != ' ')
                {
                    currStatusPuzzle[i] = '#';
                }
            }
        }


        // Return the current status of puzzle, which will be displayed on the console
        private string GetCurrenStatusPuzzle(string letter)
        {
            string puzzle = currPuzzle;
            int length = puzzle.Length;
            for (int i = 0; i < length; i++)
            {
                if (puzzle[i] == letter[0])
                {
                    currStatusPuzzle[i] = letter[0];
                }
            }

            string displayedPuzzle = new String(currStatusPuzzle);

            return displayedPuzzle.ToLower();
        }

        // Return a string of guessed letters
        private string GetGuessedLetters(string letter)
        {
            // add letter to arrayList guessedLetter
            guessedLetter.Add(letter[0]);
            // Cast arraylist to string array
            string[] guessedLetterArray = guessedLetter.Cast<string>().ToArray();
            // Convert to string array to string
            string guessedLetterString = string.Join(", ", guessedLetterArray).ToLower();

            return guessedLetterString;
        }
    }
}
