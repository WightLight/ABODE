using NUnit.Framework;

namespace Abode.Tests
{
  public class PlayerTest
  {
    [Test]
    public void GreetingShouldCostAp()
    {
      Player player = new Player();

      player.Greet();

      Assert.That(player.AP, Is.EqualTo(8));
    }
  }
}
