namespace BusinessLogic
{
    public class StandardMazeBuilder : IMazeBuilder
    {
        private Maze currentMaze = null;

        public void BuildeMaze()
        {
            this.currentMaze = new Maze();
        }

        public void BuildRoom(int roomNo)
        {
            if (currentMaze.RoomNo(roomNo) == null)
            {
                Room room = new Room(roomNo);
                
                room.SetSides(Direction.North, new Wall());
                room.SetSides(Direction.East, new Wall());
                room.SetSides(Direction.South, new Wall());
                room.SetSides(Direction.West, new Wall());

                currentMaze.AddRoom(room);
            }
        }

        public void BuildDoor(int roomFrom, int roomTo)
        {
            Room room1 = currentMaze.RoomNo(roomFrom);
            Room room2 = currentMaze.RoomNo(roomTo);
            Door door = new Door(room1, room2);

            if (room1 != null && room2 != null)
            {
                room1.SetSides(CommonWall(room1, room2), door);
                room2.SetSides(CommonWall(room2, room1), door);
            }
        }

        public Maze GetMaze()
        {
            return this.currentMaze;
        }

        private static Direction CommonWall(Room room1, Room room2)
        {
            if (room1.GetSide(Direction.North) is Wall
                && room1.GetSide(Direction.South) is Wall
                && room1.GetSide(Direction.East) is Wall
                && room1.GetSide(Direction.West) is Wall
                && room2.GetSide(Direction.North) is Wall
                && room2.GetSide(Direction.South) is Wall
                && room2.GetSide(Direction.East) is Wall
                && room2.GetSide(Direction.West) is Wall)
            {
                return Direction.East;
            }
            return Direction.West;
        }
    }
}
