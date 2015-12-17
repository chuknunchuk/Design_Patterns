using System;
using System.Collections.Generic;

namespace BusinessLogic
{
    public class Room : MapSite
    {
        private int roomNumber = 0;
        private Dictionary<Direction, MapSite> sides;

        public int RoomNumber
        {
            get { return roomNumber; }
            set { roomNumber = value; }
        }

        public Room(int rooomNu)
        {
            this.sides = new Dictionary<Direction, MapSite>(4);
            this.roomNumber = rooomNu;
        }

        public override void Enter()
        {
            Console.WriteLine("Room");
        }

        public MapSite GetSide(Direction direction)
        {
            return this.sides[direction];
        }

        public void SetSides(Direction direction, MapSite mapSite)
        {
            this.sides.Add(direction, mapSite);
        }
        
    }
}
