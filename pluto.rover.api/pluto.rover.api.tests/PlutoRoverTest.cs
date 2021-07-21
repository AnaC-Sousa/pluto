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
  }
}

