using NUnit.Framework;

namespace pluto.rover.api.tests
{
  public class Tests
  {
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void CreatePluto_ShouldReturn100Size()
    {
      var plutoCreator =  new PlutoCreator();

      var pluto = plutoCreator.CreatePluto();

      Assert.IsTrue(pluto.Size.Equals("100;100"));
    }

    [Test]
    public void InitiateRover_ShouldReturnInitialPosition()
    {
      var roverOrders = new RoverOrders();

      var roverInitialized = roverOrders.Initialize();

      Assert.IsTrue(roverInitialized.Position.Equals("0;0") && roverInitialized.Direction.Equals('N'));
    }

    [Test]
    public void GoInFront_ShouldRetunOneUnityMoreInNorth()
    {
      var roverOrders = new RoverOrders();

      Rover rover = roverOrders.Initialize();

      rover = roverOrders.GoFront();

      Assert.IsTrue(rover.Position.Equals("0;1") && rover.Direction.Equals('N'));
    }

  }
}

