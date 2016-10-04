using UnityEngine;
using System.Collections;

public class CharacterData : MonoBehaviour {

    public static int[,] characterData;
    public static int numCharacters = 25;

	// Use this for initialization
	void Start () {
        characterData = new int[numCharacters, 4];

        for (int i=0; i<numCharacters; i++)
        {
            int Hair = Random.Range(0, 23);
            int Pants = Random.Range(0, 3);
            int Shirt = Random.Range(0, 7);
            int Skin = Random.Range(0, 1);

            //prevent duplicates of killer
            while(Hair == characterData[0,0] && Pants == characterData[0, 1] && Shirt == characterData[0, 2] && Skin == characterData[0, 3])
            {
                Hair = Random.Range(0, 23);
                Pants = Random.Range(0, 3);
                Shirt = Random.Range(0, 7);
                Skin = Random.Range(0, 1);
            }

            characterData[i,0] = Hair;
            characterData[i,1] = Pants;
            characterData[i,2] = Shirt;
            characterData[i,3] = Skin;
        }
    }
}
