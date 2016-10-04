using UnityEngine;
using System.Collections;

public class ChangeSprite : MonoBehaviour {
    
    public string bodyPart;
    public Sprite[] colorOptions;

	// Use this for initialization
	void Start () {
        if (bodyPart.Equals("Pants"))
        {
            this.GetComponent<SpriteRenderer>().sprite = colorOptions[CharacterData.characterData[transform.root.GetComponent<CharacterSpecificData>().currentCharacterNumber,1]];
            this.GetComponent<SpriteRenderer>().sortingOrder = 2 * transform.root.GetComponent<CharacterSpecificData>().currentCharacterNumber;
        }
        else if (bodyPart.Equals("Shirt"))
        {
            this.GetComponent<SpriteRenderer>().sprite = colorOptions[CharacterData.characterData[transform.root.GetComponent<CharacterSpecificData>().currentCharacterNumber,2]];
            this.GetComponent<SpriteRenderer>().sortingOrder = 2 * transform.root.GetComponent<CharacterSpecificData>().currentCharacterNumber;
        }
        else if (bodyPart.Equals("Skin"))
        {
            this.GetComponent<SpriteRenderer>().sprite = colorOptions[CharacterData.characterData[transform.root.GetComponent<CharacterSpecificData>().currentCharacterNumber,3]];
            this.GetComponent<SpriteRenderer>().sortingOrder = 2 * transform.root.GetComponent<CharacterSpecificData>().currentCharacterNumber-1;
        }
        else if (bodyPart.Equals("Hair"))
        {
            this.GetComponent<SpriteRenderer>().sprite = colorOptions[CharacterData.characterData[transform.root.GetComponent<CharacterSpecificData>().currentCharacterNumber, 0]];
            this.GetComponent<SpriteRenderer>().sortingOrder = 2*transform.root.GetComponent<CharacterSpecificData>().currentCharacterNumber+1;
        }
    }
}
