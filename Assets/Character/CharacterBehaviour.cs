namespace Abode.Unity
{
  using UnityEngine;
  using TMPro;

  public class CharacterBehaviour : MonoBehaviour
  {
    private Character character;
    private TMP_Text nameField;
    private TMP_Text hpField;

    void Awake()
    {
      character = new Character("Sizzle Lizard", 12);
      nameField = transform.FindDeep("Name Text").GetComponent<TMP_Text>();
      hpField = transform.FindDeep("HP Text").GetComponent<TMP_Text>();
    }

    void Update()
    {
      nameField.text = character.Name;
      hpField.text = character.HP.ToString();
    }
  }

}