using NUnit.Framework;

namespace Abode.Tests
{
  public class PlayerTest
  {
    [Test]
    public void ConsumingAp()
    {
      Player player = new Player();

      player.ConsumeAp(2);
      Assert.That(player.AP, Is.EqualTo(8));

      player.ConsumeAp(3);
      Assert.That(player.AP, Is.EqualTo(5));
    }
  }
}
