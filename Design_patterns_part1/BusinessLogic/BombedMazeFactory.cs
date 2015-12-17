using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class BombedMazeFactory : MazeFactory
    {
        public override Room MakeRoom(int number)
        {
            return new RoomWithBomb(number);
        }

        public override Wall MakeWall()
        {
            return new BomnedWall();
        }
    }
}
