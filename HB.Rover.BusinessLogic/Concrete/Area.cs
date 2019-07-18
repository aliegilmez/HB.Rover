using HB.Rover.BusinessLogic.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace HB.Rover.BusinessLogic.Concrete
{
    public class Area : IArea
    {
        private Coordinates coordinates { get; set; }
        public List<IRover> rovers { get; set; }
        public Area(Coordinates coordinates)
        {
            this.coordinates = coordinates;
            rovers = new List<IRover>();
        }
        public void AddRover(IRover rover)
        {
            rovers.Add(rover);
        }

        public void MoveRover()
        {
            foreach (Rover rover in rovers)
            {
                rover.ProcessDirectionList();
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            Console.WriteLine("----- Result -----");
            sb.Append(Environment.NewLine);
            foreach (Rover rover in rovers)
            {
                sb.Append(String.Format("X: {0}, Y: {1}, Rover Direction: {2}", rover.X, rover.Y, rover.roverDirection));
                sb.Append(Environment.NewLine);
            }
            return sb.ToString();
        }
    }
}
