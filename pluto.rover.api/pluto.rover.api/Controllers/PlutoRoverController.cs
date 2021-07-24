using Microsoft.AspNetCore.Mvc;
using pluto.rover.api.MovesValidator;
using pluto.rover.api.Orders;
using pluto.rover.domain;

namespace pluto.rover.api.Controllers
{
  [ApiController]
  [Route("pluto")]
  public class PlutoRoverController : ControllerBase
  {
    private IRoverOrders orders;
    

    public PlutoRoverController(IRoverOrders roverOrders)
    {
      orders = roverOrders;
    }

    [HttpPut("coordinates")]
    public ActionResult ChangePosition([FromQuery] string moves)
    {
      if(string.IsNullOrEmpty(moves))
      {
        return BadRequest("Required argument is missing");
      }

      Rover rover = Rover.DefaultRover();
      foreach (char move in moves)
      {
        switch (move)
        {
          case (char) ValidMoves.Left:
            orders.TurnLeft(rover);
            break;
          case (char) ValidMoves.Right:
            orders.TurnRight(rover);
            break;
          case (char) ValidMoves.Front:
            orders.GoFront(rover);
            break;
          case (char) ValidMoves.Back:
            orders.GoBack(rover);
            break;
          default:
            return BadRequest("Invalid move");
        }
      }

      return Ok(rover.ToString());
    }

  }
}
