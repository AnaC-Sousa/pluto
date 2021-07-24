using System.Collections.Generic;

namespace pluto.rover.domain
{
  public class Pluto : IPlanet
  {
    public Grid GetGrid()
    {
      return Grid.DefaultGrid;
    }

    public ISet<Point> GetObstacles()
    {
      return new HashSet<Point> {
        new Point(0, 3),
        new Point(19, 98),
        new Point(0, 74),
        new Point(8, 46),
        new Point(36, 78),
        new Point(12, 81),
        new Point(36, 59),
        new Point(82, 88),
        new Point(2, 94),
        new Point(15, 30),
        new Point(28, 47),
        new Point(36, 45),
        new Point(60, 62),
        new Point(43, 64),
        new Point(14, 53),
        new Point(75, 91),
        new Point(47, 89),
        new Point(61, 82),
        new Point(19, 66),
        new Point(38, 54)
      };
    }
  }
}