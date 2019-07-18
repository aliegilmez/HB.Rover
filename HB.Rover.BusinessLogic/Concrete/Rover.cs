using HB.Rover.BusinessLogic.Abstract;
using System;

namespace HB.Rover.BusinessLogic.Concrete
{
    public class Rover : IRover
    {
        private Coordinates coordinates;
        private Direction direction;
        private string directionList { get; set; }

        public int X => coordinates.X;
        public int Y => coordinates.Y;
        public Direction roverDirection => direction;
        public Rover(RoverDirectionModel roverDirection)
        {
            coordinates = new Coordinates(roverDirection.X, roverDirection.Y);
            direction = GetDirection(roverDirection.directionChar);
            directionList = roverDirection.directionList;
        }
        public Direction GetDirection(char direcitonChar)
        {
            switch (direcitonChar)
            {
                case 'N':
                    return Direction.North;
                case 'S':
                    return Direction.South;
                case 'E':
                    return Direction.East;
                case 'W':
                    return Direction.West;
                default:
                    throw new Exception("Accepted values are N,S,E,W");
            }
        }

        public void ProcessDirection(char direction)
        {
            if ((direction == 'L') || (direction == 'R'))
            {
                ProcessDirectionInstruction(direction);
            }
            else if (direction == 'M')
                ProcessMove();
            else
                throw new Exception("Please supply only L,R, M");
        }

        public void ProcessDirectionInstruction(char directionChar)
        {
            int directionInt = (int)direction;

            if (directionChar == 'L')
            {
                if (directionInt == 0) directionInt = 4;
                direction = (Direction)(directionInt - 1);
            }
            else
            {
                if (directionInt == 3) directionInt = -1;
                direction = (Direction)(directionInt + 1);
            }
        }

        public void ProcessDirectionList()
        {
            foreach (char item in directionList)
                ProcessDirection(item);
        }

        public void ProcessMove()
        {
            coordinates.ChangeCoordinate(direction);
        }
    }
}
