using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic
{
    public class Maze
    {
        Dictionary<int, Room> rooms = null;

        public Maze()
        {
            this.rooms = new Dictionary<int, Room>();
        }

        public void AddRoom(Room room)
        {
            rooms.Add(room.RoomNumber, room);
        }

        public void RemoveRoom(Room room)
        {
            rooms.Remove(room.RoomNumber);
        }

        public Room RoomNo(int number)
        {
            if (rooms.Count > number)
                return rooms[number];
            return null;
        }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();
            foreach (var room in rooms)
            {
                stringBuilder.Append(room.Key + " ");
            }
            return stringBuilder.ToString();
        }
    }
}
