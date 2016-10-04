using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class CharacterClicked : MonoBehaviour {

    public Sprite[] splat;
    bool characterNotClicked = true;

    void OnMouseDown()
    {
        if (this.GetComponent<CharacterSpecificData>().isKiller)
        {
            SceneManager.LoadScene(0);
        }
        else if (characterNotClicked)
        {
            this.GetComponent<SpriteRenderer>().sprite = splat[CharacterData.characterData[this.GetComponent<CharacterSpecificData>().currentCharacterNumber, 2]];
            this.GetComponent<AIMovement>().enabled = false;
            this.transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 50));
            characterNotClicked = false;
            Destroy(this.transform.GetChild(0).gameObject);
        }
    }
}
