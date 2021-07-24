using pluto.rover.domain.Operations;

namespace pluto.rover.domain
{
  public class Rover
  {
    public RoverOperations RoverOperations { get; set; }

    public string GetDirection()
    {
      return RoverOperations.GetDirection();
    }
    public int GetXPosition()
    {
      return RoverOperations.Coordinates.X;
    }

    public int GetYPosition()
    {
      return RoverOperations.Coordinates.Y;
    }

    public override string ToString()
    {
      return RoverOperations.ToString();
    }

    public Rover GoBack()
    {
      RoverOperations = RoverOperations.GoBack();
      return this;
    }

    public Rover GoFront()
    {
      RoverOperations = RoverOperations.GoFront();
      return this;
    }

    public Rover TurnLeft()
    {
      RoverOperations = RoverOperations.TurnLeft();
      return this;
    }

    public Rover TurnRight()
    {
      RoverOperations = RoverOperations.TurnRight();
      return this;
    }

    public static Rover DefaultRover()
    {
      return new Rover { RoverOperations = new RoverNorthOperations(SolarSystem.Pluto, Point.DefaultPoint()) };
    }
  }
}
