using UnityEngine;
using System.Collections;

public class CharacterClicked : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        
	}
    
    void OnMouseDown()
    {
        if (this.GetComponent<CharacterSpecificData>().isKiller)
        {
            Application.LoadLevel(Application.loadedLevel);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
}
