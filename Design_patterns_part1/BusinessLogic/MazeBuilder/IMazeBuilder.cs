namespace BusinessLogic
{
    public interface IMazeBuilder
    {
        void BuildeMaze();
        void BuildRoom(int roomNo);
        void BuildDoor(int roomFrom, int roomTo);
        Maze GetMaze();
    }
}
