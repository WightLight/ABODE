namespace Abode.Unity
{
  using UnityEngine;
  using UnityEngine.UI;

  public class CharacterBehaviour : MonoBehaviour
  {
    [SerializeField] private GameContext gameContext;
    private Character character;
    private TextField nameField;
    private TextField hpField;
    private Button shootButton;

    void Awake()
    {
      character = gameContext.Game.Character;
      nameField = transform.FindDeep("Title Text").GetComponent<TextField>();
      hpField = transform.FindDeep("HP Text").GetComponent<TextField>();
      shootButton = transform.FindDeep("Shoot Action Panel").GetComponent<Button>();
    }

    void Update()
    {
      nameField.text = character.Name.ToUpper();
      hpField.text = character.HP.ToString() + " HP";
      shootButton.interactable = GetShootAction().IsApplicable();
    }

    public void Shoot()
    {
      GetShootAction().Act();
    }

    private ShootAction GetShootAction()
    {
      return gameContext.Game.Player.Actions(character)[0];
    }
  }

}