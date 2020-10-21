namespace Abode
{
  using System.Collections.Generic;

  public class Player
  {
    private int ap;
    public int AP
    {
      get { return ap; }
    }

    public List<Item> Items { get; }

    public Player()
    {
      ap = 10;
      Items = new List<Item> {
        new Item("Crossbow")
      };
    }

    public void ConsumeAp(int amount)
    {
      ap -= amount;
    }

    public List<ShootAction> Actions(Character character)
    {
      return new List<ShootAction> {
        new ShootAction(this, character)
      };
    }
  }
}
