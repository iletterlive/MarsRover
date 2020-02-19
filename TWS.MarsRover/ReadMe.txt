 
 MarsRover: Position and Location => (x, y, Z), where Z in {N, E, W, S} 
            Command (LMLMLM) =>  (L=SpinLeft, R=SpinRight, M=MoveForward) 
			
  Plateau: Grid of positions = (x, y), where (0, 0) => (x=0, y=0) 
            MaximumCoordinates => (maxX, maxY) => (5 5) 
        
		 Input = 5 lines: 
         1. Plateau Size: (5 5) 
         2. Array of Roverinstruction objects, where Roverinstruction object contains: 
                 a. RoverPosition (first line) 
                 b. RoverCommand (second line) 
         1. Rover Should Spin Left 
         2. Rover Should Spin Right 
         3. Rover Should Move Forward 