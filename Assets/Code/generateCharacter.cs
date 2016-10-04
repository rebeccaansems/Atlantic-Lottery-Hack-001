using UnityEngine;
using System.Collections;

public class GenerateCharacter : MonoBehaviour
{
    public GameObject character;

    // Use this for initialization
    void Start()
    {
        for(int i=0; i<CharacterData.numCharacters; i++)
        {
            GameObject newCharacter = (GameObject)Instantiate(character, new Vector2(Random.Range(-5f, 5f), Random.Range(-2.1f, 4f)), Quaternion.identity);
            newCharacter.GetComponent<CharacterSpecificData>().currentCharacterNumber = i;
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
