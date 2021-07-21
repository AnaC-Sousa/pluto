using System;
using System.Collections.Generic;

namespace pluto.rover.api
{
  public class PlutoCreator
  {
    private const string PLUTO_SIZE = "100;100";

    public PlutoCreator()
    {
    }

    public Pluto CreatePluto()
    {
      return new Pluto { Size = PLUTO_SIZE };
    }
  }
}
