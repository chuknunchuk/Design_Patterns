using System;

namespace BusinessLogic
{
    public class Door : MapSite
    {
        private Room room1 = null;
        private Room room2 = null;
        private bool isOpen;

        public Door(Room room1, Room room2)
        {
            this.room1 = room1;
            this.room2 = room2;
        }

        public override void Enter()
        {
            Console.WriteLine("Door");
        }

        public Room OtherSideFrom(Room room)
        {
            if (room == room1)
                return room2;
            else
                return room1;
        }
    }
}
