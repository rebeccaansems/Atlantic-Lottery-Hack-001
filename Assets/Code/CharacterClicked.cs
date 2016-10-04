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
            CharacterData.secondsToFinish += (int)Time.timeSinceLevelLoad;
            SceneManager.LoadScene(3);
        }
        else if (characterNotClicked)
        {
            CharacterData.secondsToFinish += 5;
            this.GetComponent<SpriteRenderer>().sprite = splat[CharacterData.characterData[this.GetComponent<CharacterSpecificData>().currentCharacterNumber, 2]];
            this.GetComponent<AIMovement>().enabled = false;
            this.transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 50));
            characterNotClicked = false;
            Destroy(this.transform.GetChild(0).gameObject);
        }
    }
}
