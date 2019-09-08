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

    public Player()
    {
      ap = 10;
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
