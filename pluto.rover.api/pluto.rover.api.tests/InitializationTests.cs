using NUnit.Framework;
using pluto.rover.domain;

namespace pluto.rover.api.tests
{
  public class InitializationTests
  {

    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void CreatePluto_ShouldReturn100Size()
    {
      Grid plutoGrid = SolarSystem.Pluto.GetGrid();
      Grid grid = new Grid(100, 100);

      Assert.IsTrue(plutoGrid.Height == grid.Height && plutoGrid.Width == grid.Width);
    }

    [Test]
    public void InitiateRover_ShouldReturnInitialPosition()
    {
      Rover roverInitialized = Rover.DefaultRover();

      
      Assert.IsTrue(roverInitialized.GetXPosition() == 0 &&
        roverInitialized.GetYPosition() == 0 &&
        roverInitialized.RoverOperations.GetDirection().Equals("N"));
    }
  }
}

