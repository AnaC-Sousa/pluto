namespace pluto.rover.domain
{
  public class Pluto : IPlanet
  {
    public Grid GetGrid()
    {
      return Grid.DefaultGrid;
    }
  }
}