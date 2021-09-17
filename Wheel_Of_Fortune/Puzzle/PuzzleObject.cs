namespace Wheel_Of_Fortune
{
    public class PuzzleObject 
    {
        public readonly string hint;
        public readonly string currentStatusPuzzle;
        public readonly string guessedLetter;
        public PuzzleObject(string hint, string currentStatusPuzzle, string guessedLetter)
        {
            this.hint = hint;
            this.currentStatusPuzzle = currentStatusPuzzle;
            this.guessedLetter = guessedLetter;
        }
    }
}
