using System;
using pluto.rover.domain.Operations;

namespace pluto.rover.domain.Exceptions
{
  public class FoundObstacleException : Exception
  {
    public FoundObstacleException(RoverOperations roverOperations) : base($@"Found one obstacle. Rover stuck at: {roverOperations}")
    {
    }
  }
}
