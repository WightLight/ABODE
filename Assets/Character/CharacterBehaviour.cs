namespace Abode.Unity
{
  using UnityEngine;
  using TextField = TMPro.TMP_Text;

  public class CharacterBehaviour : MonoBehaviour
  {
    private Character character;
    private TextField nameField;
    private TextField hpField;

    void Awake()
    {
      character = new Character("Sizzle Lizard", 12);
      nameField = transform.FindDeep("Name Text").GetComponent<TextField>();
      hpField = transform.FindDeep("HP Text").GetComponent<TextField>();
    }

    void Update()
    {
      nameField.text = character.Name;
      hpField.text = character.HP.ToString();
    }
  }

}