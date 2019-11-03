
namespace Abode.Tests
{
  using NUnit.Framework;

  public class ShootActionTest
  {
    Player player;
    Character character;
    ShootAction action;

    [SetUp]
    public void Init()
    {
      player = new Player();
      character = new Character("Colin", 10);
      action = new ShootAction(player, character);
    }

    [Test]
    public void DamagesTarget()
    {
      action.Act();

      Assert.That(character.HP, Is.EqualTo(8));
    }

    [Test]
    public void ConsumesPlayerAp()
    {
      action.Act();

      Assert.That(player.AP, Is.EqualTo(7));
    }

    [Test]
    public void RequiresEnoughAp()
    {
      Assert.That(action.IsApplicable(), Is.True);

      action.Act();
      action.Act();
      action.Act();

      Assert.That(action.IsApplicable(), Is.False);
    }
  }
}
