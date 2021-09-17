using System;

namespace Wheel_Of_Fortune
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Game game = new Game();
            game.StartGame();
        }
    }
}