using UnityEngine;
using UnityEngine.SceneManagement;
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
            SceneManager.LoadScene(0);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
}
