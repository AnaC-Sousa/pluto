using NUnit.Framework;
using pluto.rover.api.Orders;
using pluto.rover.domain;
using pluto.rover.domain.Exceptions;

namespace pluto.rover.api.tests
{
  public class PlutoObstaclesTests
  {

    private RoverOrders roverOrders;
    private Rover rover;

    [SetUp]
    public void Setup()
    {
      roverOrders = new RoverOrders();
      rover = Rover.DefaultRover();
    }


    [Test]
    public void GoInFront_ShouldFindObstacle()
    {
      Assert.Throws<FoundObstacleException>(() => roverOrders.GoFront(rover).GoFront().GoFront(),
        "Found one obstacle.Rover stuck at: 0,2;N");
      
    }
  }
}

