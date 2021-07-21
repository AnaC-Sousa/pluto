using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace pluto.rover.api.Controllers
{
  [ApiController]
  [Route("pluto")]
  public class PlutoRoverController : ControllerBase
  {
    private static readonly List<char> Directions = new() { 'N', 'S', 'W', 'E' };

    public PlutoRoverController()
    {
    }

    [HttpPut("coordinates")]
    public ActionResult ChangePosition([FromQuery] int x, int y, char direction)
    {
      if(string.IsNullOrEmpty(direction.ToString()))
      {
        return BadRequest("Required argument is missing - direction");
      }
      if( !Directions.Contains(direction))
      {
        return BadRequest("Invalid direction");
      }

      return Ok();
    }

  }
}
