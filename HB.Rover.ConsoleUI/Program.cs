using HB.Rover.BusinessLogic;
using HB.Rover.BusinessLogic.Concrete;
using System;

namespace HB.Rover.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Area area = new Area(new Coordinates(5, 5));
            RoverDirectionModel roverDirection = new RoverDirectionModel
            {
                X = 1,
                Y = 2,
                directionChar = 'N',
                directionList = "LMLMLMLMM"
            };
            area.AddRover(new BusinessLogic.Concrete.Rover(roverDirection));
            area.MoveRover();

            Console.WriteLine(area.ToString());
            Console.ReadKey();
        }
    }
}
