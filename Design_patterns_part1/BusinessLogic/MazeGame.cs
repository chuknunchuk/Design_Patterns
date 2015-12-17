using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class MazeGame
    {
        private IMazeFactory factory = null;
        public Maze CreateMaze(IMazeFactory factory)
        {
            this.factory = factory;
            Maze aMaze = this.factory.MakeMaze();
            Room r1 = this.factory.MakeRoom(1);
            Room r2 = this.factory.MakeRoom(2);
            Door aDoor = this.factory.MakeDoor(r1, r2);

            aMaze.AddRoom(r1);
            aMaze.AddRoom(r2);

            r1.SetSides(Direction.North, this.factory.MakeWall());
            r1.SetSides(Direction.East, aDoor);
            r1.SetSides(Direction.South, this.factory.MakeWall());
            r1.SetSides(Direction.West, this.factory.MakeWall());

            r2.SetSides(Direction.North, this.factory.MakeWall());
            r2.SetSides(Direction.East, this.factory.MakeWall());
            r2.SetSides(Direction.South, this.factory.MakeWall());
            r2.SetSides(Direction.West, aDoor);

            return aMaze;
        }

    }
}
