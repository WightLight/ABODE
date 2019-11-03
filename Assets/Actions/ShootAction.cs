namespace Abode
{
  public class ShootAction
  {
    private Player actor;
    private Character target;

    public ShootAction(Player actor, Character target)
    {
      this.actor = actor;
      this.target = target;
    }

    public bool IsApplicable()
    {
      return actor.AP >= 3;
    }

    public void Act()
    {
      actor.ConsumeAp(3);
      target.Damage(2);
    }
  }
}