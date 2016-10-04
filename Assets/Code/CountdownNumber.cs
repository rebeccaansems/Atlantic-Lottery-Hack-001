using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class CountdownNumber : MonoBehaviour
{
    public Text number;

    // Update is called once per frame
    void Update()
    {
        if (Time.fixedTime == 1)
        {
            number.text = "5";
        }
        else if (Time.fixedTime == 2)
        {
            number.text = "4";
        }
        else if (Time.fixedTime == 3)
        {
            number.text = "3";
        }
        else if (Time.fixedTime == 4)
        {
            number.text = "2";
        }
        else if (Time.fixedTime == 5)
        {
            number.text = "1";
        }
        else if (Time.fixedTime == 6)
        {
            SceneManager.LoadScene(2);
        }
    }
}
