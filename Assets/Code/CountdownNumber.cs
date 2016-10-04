using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class CountdownNumber : MonoBehaviour
{
    public Text number;
    public GameObject wantedCharacter;

    // Update is called once per frame
    void Update()
    {
        if (Time.timeSinceLevelLoad < 1)
        {
            number.text = "5";
        }
        else if (Time.timeSinceLevelLoad < 2)
        {
            number.text = "4";
        }
        else if (Time.timeSinceLevelLoad < 3)
        {
            number.text = "3";
        }
        else if (Time.timeSinceLevelLoad < 4)
        {
            number.text = "2";
        }
        else if (Time.timeSinceLevelLoad < 5)
        {
            number.text = "1";
        }
        else if (Time.timeSinceLevelLoad < 8)
        {
            number.text = "";
            wantedCharacter.transform.position = new Vector3(wantedCharacter.transform.position.x, wantedCharacter.transform.position.y, 0);
        }
        else
        {
            SceneManager.LoadScene(2);
        }
    }
}
