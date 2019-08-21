namespace Abode
{
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

    public void Greet()
    {
      ap -= 2;
    }
  }
}
