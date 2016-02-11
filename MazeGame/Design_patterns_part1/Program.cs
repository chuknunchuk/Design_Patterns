using System;
using BusinessLogic;

namespace Design_patterns_part1
{
    class Program
    {
        static void Main()
        {
            var factory = new BombedMazeFactory();
            var game = new MazeGame();
            var maze = game.CreateMaze(factory);
            Console.WriteLine(maze.ToString());

            maze = game.CreateMaze(new StandardMazeBuilder());
            Console.WriteLine(maze.ToString());

            maze = game.CreateComplexMaze(new StandardMazeBuilder());
            Console.WriteLine(maze.ToString());
            Console.ReadKey();
        }
    }
}
