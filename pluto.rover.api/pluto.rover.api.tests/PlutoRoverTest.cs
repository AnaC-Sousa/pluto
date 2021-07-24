using NUnit.Framework;
using pluto.rover.api.Orders;
using pluto.rover.domain;

namespace pluto.rover.api.tests
{
  public class PlutoRoverTest
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
    public void GoInFront_ShouldRetunOneUnityMoreInNorth()
    {
      roverOrders.GoFront(rover);
      
      Assert.IsTrue(rover.GetXPosition() == 0 &&
        rover.GetYPosition() == 1 &&
        rover.GetDirection().Equals("N"));
    }

    [Test]
    public void GoBack_ShouldReturnOneUnityLessInNorth()
    {
      roverOrders.GoBack(rover);

      Assert.IsTrue(rover.GetXPosition() == 0 &&
        rover.GetYPosition() == 99 &&
        rover.GetDirection().Equals("N"));
    }

    [Test]
    public void TurnLeft_ShouldReturnWest()
    {
      roverOrders.TurnLeft(rover);

      Assert.IsTrue(rover.GetXPosition() == 0 &&
        rover.GetYPosition() == 0 &&
        rover.GetDirection().Equals("W"));
    }

    [Test]
    public void TurnRight_ShouldReturnEast()
    {
      roverOrders.TurnRight(rover);

      Assert.IsTrue(rover.GetXPosition() == 0 &&
        rover.GetYPosition() == 0 &&
        rover.GetDirection().Equals("E"));
    }

    [Test]
    public void TurnRight_ShouldReturnSouth()
    {
      roverOrders.TurnRight(rover).TurnRight();

      Assert.IsTrue(rover.GetXPosition() == 0 &&
        rover.GetYPosition() == 0 &&
        rover.GetDirection().Equals("S"));
    }

    [Test]
    public void MoveFrontFrontRightBack_ReturnCoordinates()
    {
      roverOrders.GoFront(rover).GoFront().TurnRight().GoBack();

      Assert.IsTrue(rover.GetXPosition() == 99 &&
        rover.GetYPosition() == 2 &&
        rover.GetDirection().Equals("E"));
    }

    [Test]
    public void MoveFrontBack_ReturnCoordinates()
    {
      roverOrders.GoFront(rover).GoBack();

      Assert.IsTrue(rover.GetXPosition() == 0 &&
        rover.GetYPosition() == 0 &&
        rover.GetDirection().Equals("N"));
    }

    [Test]
    public void MoveInSquareLeft_ReturnCoordinates()
    {
      roverOrders.GoFront(rover).TurnLeft().
        GoFront().TurnLeft().
        GoFront().TurnLeft().
        GoFront().TurnLeft();

      Assert.IsTrue(rover.GetXPosition() == 0 &&
        rover.GetYPosition() == 0 &&
        rover.GetDirection().Equals("N"));
    }

    [Test]
    public void MoveInSquareRight_ReturnCoordinates()
    {
      roverOrders.GoFront(rover).TurnRight().
        GoFront().TurnRight().
        GoFront().TurnRight().
        GoFront().TurnRight();

      Assert.IsTrue(rover.GetXPosition() == 0 &&
        rover.GetYPosition() == 0 &&
        rover.GetDirection().Equals("N"));
    }

    [Test]
    public void GoToRightUpCorner_Return99_99()
    {
      roverOrders.GoBack(rover).TurnRight().GoBack();

      Assert.IsTrue(rover.GetXPosition() == 99 &&
        rover.GetYPosition() == 99);
    }

    [Test]
    public void GoToLeftUpCorner_Return0_99()
    {
      roverOrders.GoBack(rover);

      Assert.IsTrue(rover.GetXPosition() == 0 &&
        rover.GetYPosition() == 99);
    }

    [Test]
    public void GoToRightDownCorner_Return99_0()
    {
      roverOrders.TurnRight(rover).GoBack();

      Assert.IsTrue(rover.GetXPosition() == 99 &&
        rover.GetYPosition() == 0);
    }
  }
}

