namespace Abode.Unity
{
  using UnityEngine;

  public class GameContext : MonoBehaviour
  {
    private Game game;
    public Game Game
    {
      get { return game; }
    }

    public void Awake()
    {
      game = new Game(
        new Player(),
        new Character("Sizzle Lizard", 12)
      );
    }
  }
}