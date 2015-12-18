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
