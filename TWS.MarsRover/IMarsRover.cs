using System;
using System.Collections.Generic;
using System.Text;

namespace TWS.MarsRover
{
    public interface IMarsRover
    {
        void MoveRover(IPlateau plateau, string position, string commands);
    }
}
