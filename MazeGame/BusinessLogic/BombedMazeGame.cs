namespace BusinessLogic
{
    class BombedMazeGame : MazeGame
    {
        public BombedMazeGame()
        {
        }
        public override Wall MakeWall()
        {
            return new BombedWall();
        }
        public override Room MakeRoom(int number)
        {
            return new RoomWithBomb(number);
        }
    }
}
