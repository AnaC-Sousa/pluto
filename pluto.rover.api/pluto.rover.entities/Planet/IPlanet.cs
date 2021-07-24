using System.Collections.Generic;

namespace pluto.rover.domain
{
    public interface IPlanet
    {
      public Grid GetGrid();
      public ISet<Point> GetObstacles();
    }

    public static class SolarSystem
    {
      public static IPlanet Pluto = new Pluto();
    }
}