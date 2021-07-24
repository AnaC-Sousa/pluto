namespace pluto.rover.domain
{
    public interface IPlanet
    {
      public Grid GetGrid();
    }

    public static class SolarSystem
    {
      public static IPlanet Pluto = new Pluto();
    }
}