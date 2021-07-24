using pluto.rover.domain;

namespace pluto.rover.api.Orders
{
  public class RoverOrders : IRoverOrders
  {
    public Rover GoFront(Rover rover)
    {
      return rover.GoFront();
    }

    public Rover GoBack(Rover rover)
    {
      return rover.GoBack();
    }

    public Rover TurnLeft(Rover rover)
    {
      return rover.TurnLeft();
    }

    public Rover TurnRight(Rover rover)
    {
      return rover.TurnRight();
    }
  }
}
