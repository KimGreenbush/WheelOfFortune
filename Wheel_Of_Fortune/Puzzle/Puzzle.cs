using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wheel_Of_Fortune
{
    class Puzzle
    {
        public string puzzle;
        public string length;
        public string hint;
        public Puzzle(string puzzle, string hint)
        {
            this.puzzle = puzzle.ToLower();
            this.length = puzzle.Length.ToString().ToLower();
            this.hint = hint.ToLower();
        }
    }
}
