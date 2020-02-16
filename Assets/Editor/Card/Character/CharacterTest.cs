
namespace Abode.Tests
{
  using NUnit.Framework;

  public class CharacterTest
  {
    [Test]
    public void DamageReducesCharacterHP()
    {
      Character character = new Character("Colin", 10);

      character.Damage(2);

      Assert.That(character.HP, Is.EqualTo(8));
    }
  }
}
