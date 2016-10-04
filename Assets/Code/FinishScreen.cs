using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FinishScreen : MonoBehaviour {

    public Text time;

	// Use this for initialization
	void Start () {
        time.text = CharacterData.secondsToFinish + " Sec";
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
