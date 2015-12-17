using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public interface IMazeFactory
    {
        Maze MakeMaze();
        Wall MakeWall();
        Room MakeRoom(int number);
        Door MakeDoor(Room room1, Room room2);
    }

}
