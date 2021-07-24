namespace pluto.rover.domain.Operations
{
  public abstract class RoverOperations
  {
    public Point Coordinates { get; set; }
    public IPlanet Planet { get; set; }

    public RoverOperations(IPlanet planet, Point coordinates)
    {
      this.Coordinates = coordinates;
      this.Planet = planet;
    }

    public abstract RoverOperations GoFront();
    public abstract RoverOperations GoBack();
    public abstract RoverOperations TurnLeft();
    public abstract RoverOperations TurnRight();
    public abstract string GetDirection();


    public override string ToString()
    {
      return $@"{Coordinates};{GetDirection()}";
    }
  }
}
