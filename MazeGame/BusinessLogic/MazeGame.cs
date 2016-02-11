namespace BusinessLogic
{
    public class MazeGame
    {
        private IMazeFactory factory = null;
        public Maze CreateMaze(IMazeFactory factory)
        {
            this.factory = factory;
            Maze aMaze = this.factory.MakeMaze();
            Room r1 = this.factory.MakeRoom(1);
            Room r2 = this.factory.MakeRoom(2);
            Door aDoor = this.factory.MakeDoor(r1, r2);

            aMaze.AddRoom(r1);
            aMaze.AddRoom(r2);

            r1.SetSides(Direction.North, this.factory.MakeWall());
            r1.SetSides(Direction.East, aDoor);
            r1.SetSides(Direction.South, this.factory.MakeWall());
            r1.SetSides(Direction.West, this.factory.MakeWall());

            r2.SetSides(Direction.North, this.factory.MakeWall());
            r2.SetSides(Direction.East, this.factory.MakeWall());
            r2.SetSides(Direction.South, this.factory.MakeWall());
            r2.SetSides(Direction.West, aDoor);

            return aMaze;
        }

        public Maze CreateMaze(IMazeBuilder builder)
        {
            builder.BuildeMaze();
            builder.BuildRoom(1);
            builder.BuildRoom(2);
            builder.BuildDoor(1,2);

            return builder.GetMaze();
        }

        public Maze CreateComplexMaze(IMazeBuilder builder)
        {
            builder.BuildeMaze();

            for (int i = 0; i < 11; i++)
            {
                builder.BuildRoom(i+1);
            }

            return builder.GetMaze();
        }

        public virtual Maze MakeMaze()
        {
            return new Maze();
        }

        public virtual Room MakeRoom(int number)
        {
            return new Room(number);
        }

        public virtual Wall MakeWall()
        {
            return new Wall();
        }

        public virtual Door MakeDoor(Room room1, Room room2)
        {
            return new Door(room1, room2);
        }

    }
}
