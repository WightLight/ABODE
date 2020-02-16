namespace Abode
{
  public class Character
  {
    private string name;
    public string Name
    {
      get { return name; }
    }

    private int hp;
    public int HP
    {
      get { return hp; }
    }

    public Character(string name, int hp)
    {
      this.name = name;
      this.hp = hp;
    }

    public void Damage(int damage)
    {
      this.hp -= damage;
    }
  }
}