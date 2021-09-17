using System;

namespace Wheel_Of_Fortune
{
    class Program
    {
        static void Main(string[] args)
        {
            // Set default console settings
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Game game = new Game();
            game.StartGame();
        }
    }
}