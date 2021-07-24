namespace pluto.rover.domain
{
    public class Grid
    {
      public static Grid DefaultGrid = new Grid(100, 100);

      public readonly int Height;
      public readonly int Width;

      public Grid(int Height, int Width)
      {
        this.Height = Height;
        this.Width = Width;
      }

      public override string ToString()
      {
        return $@"{Height};{Width}";
      }
    }
}