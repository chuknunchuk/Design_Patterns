using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    class MazeGame
    {
        public Maze CreateMaze()
        {
            Maze aMaze = new Maze();
            Room r1 = new Room(1);
            Room r2 = new Room(2);
            Door theDoor = new Door(r1,r2);

            aMaze.AddRoom(r1);
            aMaze.AddRoom(r2);

            r1.SetSides(Direction.North, new Wall());
            r1.SetSides(Direction.East, theDoor);
            r1.SetSides(Direction.South, new Wall());
            r1.SetSides(Direction.West, new Wall());

            r2.SetSides(Direction.North, new Wall());
            r2.SetSides(Direction.East, new Wall());
            r2.SetSides(Direction.South, new Wall());
            r2.SetSides(Direction.West, theDoor);

            return aMaze;
        }
    }
}
