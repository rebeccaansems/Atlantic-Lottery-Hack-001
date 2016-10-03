using UnityEngine;
using System.Collections;

public class CharacterSpecificData : MonoBehaviour {

    public int currentCharacterNumber = 0;
    public bool isKiller = false;

    void Start()
    {
        if (currentCharacterNumber == 0)
        {
            isKiller = true;
        }
    }

}
