using System;
namespace pluto.rover.api
{
  public class RoverOrders
  {
    private const string INITIAL_POSITION = "0;0";
    private const char NORTH = 'N';
    private const char SOUTH = 'S';
    private const char WEST = 'W';
    private const char EAST = 'E';
    private const int PLUTO_LIMIT = 100;
    private Rover rover;

    public RoverOrders()
    {
    }

    public Rover Initialize()
    {
      if(rover == null)
      {
        rover = new Rover { Position = INITIAL_POSITION, Direction = NORTH };
      }
      return rover;
    }

    public Rover GoFront()
    {
      int currentYPosition = Convert.ToInt32(GetYPosition());
      int currentXPosition = Convert.ToInt32(GetXPosition());
      int futurePosition;
      switch (rover.Direction)
      {
        case NORTH:
          futurePosition = currentYPosition += 1;

          if (futurePosition > PLUTO_LIMIT)
          {
            futurePosition = 0;
          }
          rover.Position = $@"{GetXPosition()};{futurePosition}";
          return rover;
        case SOUTH:
          futurePosition = currentYPosition -= 1;

          if (futurePosition < 0)
          {
            futurePosition = PLUTO_LIMIT;
          }
          rover.Position = $@"{GetXPosition()};{futurePosition}";
          return rover;
        case EAST:
          futurePosition = currentXPosition += 1;

          if (futurePosition > PLUTO_LIMIT)
          {
            futurePosition = 0;
          }
          rover.Position = $@"{futurePosition};{GetYPosition()}";
          return rover;
        case WEST:
          futurePosition = currentXPosition -= 1;

          if (futurePosition < 0)
          {
            futurePosition = PLUTO_LIMIT;
          }
          rover.Position = $@"{futurePosition};{GetYPosition()}";
          return rover;
        default:
          throw new Exception("Direction Invalid");
      }
    }


    private string GetXPosition()
    {
      return rover.Position.Split(';')[0];
    }

    private string GetYPosition()
    {
      return rover.Position.Split(';')[1];
    }
  }
}
