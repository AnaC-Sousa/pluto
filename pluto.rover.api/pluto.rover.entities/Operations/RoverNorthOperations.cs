namespace pluto.rover.domain.Operations
{
  public class RoverNorthOperations : RoverOperations
  {

    public RoverNorthOperations(IPlanet planet, Point coordinates) : base(planet, coordinates)
    {
    }

    public override RoverOperations GoBack()
    {
      int yPosition = Coordinates.Y - 1;

      if (yPosition < 0)
      {
        yPosition = Planet.GetGrid().Height-1;
      }

      Coordinates = new Point(Coordinates.X, yPosition);
      return this;
    }

    public override RoverOperations GoFront()
    {
      int yPosition = Coordinates.Y + 1;

      if (yPosition > Planet.GetGrid().Height-1)
      {
        yPosition = 0;
      }

      Coordinates = new Point(Coordinates.X, yPosition);
      return this;
    }

    public override RoverOperations TurnLeft()
    {
      return new RoverWestOperations(Planet, new Point(Coordinates.X, Coordinates.Y));
    }

    public override RoverOperations TurnRight()
    {
      return new RoverEastOperations(Planet, new Point(Coordinates.X, Coordinates.Y));
    }

    public override string GetDirection()
    {
      return "N";
    }
  }
}
