namespace pluto.rover.domain.Operations
{
  public class RoverWestOperations : RoverOperations
  {

    public RoverWestOperations(IPlanet planet, Point coordinates) : base(planet, coordinates)
    {
    }

    public override RoverOperations GoBack()
    {
      int xPosition = Coordinates.X + 1;

      if (xPosition > Planet.GetGrid().Width-1)
      {
        xPosition = 0;
      }

      Coordinates = new Point(xPosition, Coordinates.Y);
      return this;
    }

    public override RoverOperations GoFront()
    {
      int xPosition = Coordinates.X - 1;

      if (xPosition < 0)
      {
        xPosition = Planet.GetGrid().Width-1;
      }

      Coordinates = new Point(xPosition, Coordinates.Y);
      return this;
    }

    public override RoverOperations TurnLeft()
    {
      return new RoverSouthOperations(Planet, new Point(Coordinates.X, Coordinates.Y));
    }

    public override RoverOperations TurnRight()
    {
      return new RoverNorthOperations(Planet, new Point(Coordinates.X, Coordinates.Y));
    }

    public override string GetDirection()
    {
      return "W";
    }
  }
}
