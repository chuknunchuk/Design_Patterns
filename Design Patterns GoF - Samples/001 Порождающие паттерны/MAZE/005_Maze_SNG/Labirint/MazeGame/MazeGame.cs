﻿using System;


namespace Labirint
{
    class MazeGame
    {
        // Фабрика компонентов лабиринта.
        MazeFactory factory = null;

        // Методы CreateMaze - создает лабиринт из двух комнат с одной дверью между комнатами.    

        // Использование Фабричных методов.
        public Maze CreateMaze()
        {
            Maze aMaze = this.MakeMaze();

            Room r1 = MakeRoom(1);
            Room r2 = MakeRoom(2);
            Door theDoor = MakeDoor(r1, r2);

            aMaze.AddRoom(r1);
            aMaze.AddRoom(r2);

            r1.SetSide(Direction.North, MakeWall());
            r1.SetSide(Direction.East, theDoor);
            r1.SetSide(Direction.South, MakeWall());
            r1.SetSide(Direction.West, MakeWall());

            r2.SetSide(Direction.North, MakeWall());
            r2.SetSide(Direction.East, MakeWall());
            r2.SetSide(Direction.South, MakeWall());
            r2.SetSide(Direction.West, theDoor);
            
            return aMaze;
        }

        // Использует Фабрику. 
        public Maze CreateMaze(MazeFactory factory)
        {
            this.factory = factory;

            // Лабиринт.
            Maze aMaze = this.factory.MakeMaze();

            Room r1 = this.factory.MakeRoom(1);
            Room r2 = this.factory.MakeRoom(2);

            // Дверь - данный экземпляр содержит ссылки на две комнаты. (Является общим для двух комнат.)
            Door aDoor = this.factory.MakeDoor(r1, r2);

            aMaze.AddRoom(r1);
            aMaze.AddRoom(r2);

            r1.SetSide(Direction.North, this.factory.MakeWall());
            r1.SetSide(Direction.East, aDoor);
            r1.SetSide(Direction.South, this.factory.MakeWall());
            r1.SetSide(Direction.West, this.factory.MakeWall());

            r2.SetSide(Direction.North, this.factory.MakeWall());
            r2.SetSide(Direction.East, this.factory.MakeWall());
            r2.SetSide(Direction.South, this.factory.MakeWall());
            r2.SetSide(Direction.West, aDoor);

            return aMaze;
        }

        // Использует Строителя.   
        public Maze CreateMaze(MazeBuilder builder)
        {
            builder.BuildMaze();
            builder.BuildRoom(1);
            builder.BuildRoom(2);
            builder.BuildDoor(1, 2);

            // Возвращает готовый продукт (Лабиринт)
            return builder.GetMaze();
        }

        public Maze CreateComplexMaze(MazeBuilder builder)
        {
            // Построение 1001-й комнаты.
            for (int i = 0; i < 1001; i++)
            {
                builder.BuildRoom(i + 1);
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

        public virtual Door MakeDoor(Room r1, Room r2)
        {
            return new Door(r1, r2);
        }
    }
}
