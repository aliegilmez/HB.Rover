using HB.Rover.BusinessLogic.Abstract;

namespace HB.Rover.BusinessLogic.Concrete
{
    public class Coordinates : ICoordinates
    {
        private int CoordinateX { get; set; }
        private int CoordinateY { get; set; }
        public Coordinates(int coordinateX,int coordinateY)
        {
            CoordinateX = coordinateX;
            CoordinateY = coordinateY;
        }
        public int X => CoordinateX;
        public int Y => CoordinateY;
        public void ChangeCoordinate(Direction direction)
        {
            switch (direction)
            {
                case Direction.North:
                    CoordinateY++;
                    break;
                case Direction.South:
                    CoordinateY--;
                    break;
                case Direction.East:
                    CoordinateX++;
                    break;
                case Direction.West:
                    CoordinateX--;
                    break;
            }
        }
    }
}
