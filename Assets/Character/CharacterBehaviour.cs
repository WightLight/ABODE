namespace Abode.Unity
{
  using UnityEngine;

  public class CharacterBehaviour : MonoBehaviour
  {
    private Character character;
    private TextField nameField;
    private TextField hpField;

    void Awake()
    {
      character = new Character("Sizzle Lizard", 12);
      nameField = transform.FindDeep("Title Text").GetComponent<TextField>();
      hpField = transform.FindDeep("HP Text").GetComponent<TextField>();
    }

    void Update()
    {
      nameField.text = character.Name.ToUpper();
      hpField.text = character.HP.ToString() + " HP";
    }
  }

}