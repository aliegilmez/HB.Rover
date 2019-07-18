using HB.Rover.BusinessLogic;
using HB.Rover.BusinessLogic.Concrete;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace HB.RoverUnitTest
{
    [TestClass]
    public class RoverUnitTest
    {
        [TestMethod]
        public void RoverTest()
        {
            Area area = new Area(new Coordinates(5, 5));
            RoverDirectionModel roverDirection = new RoverDirectionModel
            {
                X = 1,
                Y = 2,
                directionChar = 'N',
                directionList = "LMLMLMLMML"
            };
            area.AddRover(new Rover.BusinessLogic.Concrete.Rover(roverDirection));
            area.MoveRover();
            area.ToString();
        }
    }
}
