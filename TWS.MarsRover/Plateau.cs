using System;
using System.Collections.Generic;
using System.Text;

namespace TWS.MarsRover
{
    public class Plateau : IPlateau
    {
        public int XCoordinate { get; private set; }
        public int YCoordinate { get; private set; }

        public Plateau(int x, int y)
        {
            this.XCoordinate = x;
            this.YCoordinate = y;
        }
    }
}
