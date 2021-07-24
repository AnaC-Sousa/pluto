using pluto.rover.domain;

namespace pluto.rover.api.Orders
{
  public interface IRoverOrders
  {
    public Rover GoFront(Rover rover);

    public Rover GoBack(Rover rover);

    public Rover TurnLeft(Rover rover);

    public Rover TurnRight(Rover rover);
  }
}
