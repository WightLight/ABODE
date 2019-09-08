namespace Abode
{
  public class Game
  {
    private Player player;
    public Player Player
    {
      get { return player; }
    }

    private Character character;
    public Character Character
    {
      get { return character; }
    }

    public Game(Player player, Character character)
    {
      this.player = player;
      this.character= character;
    }
  }
}