using System;
using System.Collections.Generic;
using System.Text;

namespace TWS.MarsRover
{
    public class MarsRover : IMarsRover
    {
        public int X;
        public int Y;
        
        public Directions Direction { get; set; }

        public MarsRover()
        {
            X = Y = 0;
            Direction = Directions.N;
        }

        private void SpinLeft()
        {
            switch (this.Direction)
            {
                case Directions.N:
                    this.Direction = Directions.W;
                    break;
                case Directions.S:
                    this.Direction = Directions.E;
                    break;
                case Directions.E:
                    this.Direction = Directions.N;
                    break;
                case Directions.W:
                    this.Direction = Directions.S;
                    break;
                default:
                    throw new ArgumentException();
            }
        }

        private void SpinRight()
        {
            switch (this.Direction)
            {
                case Directions.N:
                    this.Direction = Directions.E;
                    break;
                case Directions.S:
                    this.Direction = Directions.W;
                    break;
                case Directions.E:
                    this.Direction = Directions.S;
                    break;
                case Directions.W:
                    this.Direction = Directions.N;
                    break;
                default:
                    throw new ArgumentException();
            }
        }

        private void StepForward()
        {
            switch (this.Direction)
            {
                case Directions.N:
                    this.Y += 1;
                    break;
                case Directions.S:
                    this.Y -= 1;
                    break;
                case Directions.E:
                    this.X += 1;
                    break;
                case Directions.W:
                    this.X -= 1;
                    break;
                default:
                    throw new ArgumentException();
            }
        }

        private void SetRoverPosition(string position)
        {
            Int32.TryParse(position.Split(" ")[0], out X);
            Int32.TryParse(position.Split(" ")[1], out Y);
            Direction = (Directions)Enum.Parse(typeof(Directions), position.Split(" ")[2]);
        }

        private void RoverCommands(string Commands)
        {
            char[] commands = Commands.ToCharArray();

            foreach (char command in commands)
            {
                switch (command)
                {
                    case 'M':
                        this.StepForward();
                        break;
                    case 'L':
                        this.SpinLeft();
                        break;
                    case 'R':
                        this.SpinRight();
                        break;
                    default:
                        Console.WriteLine($"Invalid Command {command}");
                        break;
                }
            }
        }
              

        public void MoveRover(IPlateau plateau, string position, string commands)
        {
            if(ValidateCoordinates(plateau))
            {
                this.SetRoverPosition(position);
                this.RoverCommands(commands);
            }     
            
        }

        private bool ValidateCoordinates(IPlateau plateau)
        {
            if (this.X < 0 || this.X > plateau.XCoordinate || this.Y < 0 || this.Y > plateau.YCoordinate)
            {
                throw new Exception($"Move beyond bounderies (0 , 0) and ({plateau.XCoordinate} , {plateau.YCoordinate})");                
            }
            return true;            
        }
        
    }
}
