using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
using pluto.rover.api.Controllers;
using pluto.rover.api.Orders;

namespace pluto.rover.api.tests
{
  public class PlutoRoverControllerTests
  {
    private PlutoRoverController controller;

    [SetUp]
    public void Setup()
    {
      RoverOrders roverOrders = new RoverOrders();
      controller = new PlutoRoverController(roverOrders);
    }


    [Test]
    public void TestCorrectMovement_OK()
    {
      ActionResult actionResult = controller.ChangePosition("FFRFF");
      var result = actionResult as OkObjectResult;
      
      Assert.IsTrue(result.Value.Equals("2,2;E"));
    }

    [Test]
    public void TestInvalidMove_BadRequest()
    {
      ActionResult actionResult = controller.ChangePosition("FFTFF");
      var result = actionResult as BadRequestObjectResult;

      Assert.IsTrue(result.Value.Equals("Invalid move"));
    }

    [Test]
    public void TestMissingArgument_BadRequest()
    {
      ActionResult actionResult = controller.ChangePosition("");
      var result = actionResult as BadRequestObjectResult;

      Assert.IsTrue(result.Value.Equals("Required argument is missing"));
    }
  }
}

