using System;
using BusinessLogic;

namespace Design_patterns_part1
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new BombedMazeFactory();
            var game = new MazeGame();
            var maze = game.CreateMaze(factory);
            Console.WriteLine(maze.ToString());
            Console.ReadKey();
        }
    }
}
