using NUnit.Framework;
using System.Collections.Generic;
using TWS.MarsRover;

namespace MarsRoverUnitTests
{
    public class MarsRoverUnitTest
    {

        [TestCase("1 2 N", "LMLMLMLMM", ExpectedResult = "1 3 N")]
        [TestCase("3 3 E", "MMRMMRMRRM", ExpectedResult = "5 1 E")]
        public string RoversDeployAndTestCoordinates(string position, string commands)
        {
            IPlateau plateau = new Plateau(5,5);

            MarsRover marsRover = new MarsRover();                      
            
            marsRover.MoveRover(plateau, position, commands);

            var Result = $"{marsRover.X} {marsRover.Y} {marsRover.Direction.ToString()}";
            return Result;            
        }      
    }
}