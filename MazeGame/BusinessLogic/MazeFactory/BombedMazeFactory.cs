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
            return new BombedWall();
        }
    }
}
