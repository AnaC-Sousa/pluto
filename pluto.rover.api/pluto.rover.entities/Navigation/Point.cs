using System;

namespace pluto.rover.domain
{
    public class Point
    {
      public readonly int X;
      public readonly int Y;

      public Point(int X, int Y)
      {
        this.X = X;
        this.Y = Y;
      }
    
      public static Point DefaultPoint()
      {
        return new Point(0, 0);
      }

    public override bool Equals(object obj)
    {
      return obj is Point point &&
             X == point.X &&
             Y == point.Y;
    }

    public override int GetHashCode()
    {
      return HashCode.Combine(X, Y);
    }

    public override string ToString()
      {
        return $@"{X},{Y}";
      }

      
    }
}