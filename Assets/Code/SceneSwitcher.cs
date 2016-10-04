using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class SceneSwitcher : MonoBehaviour {

	public void MainMenuPlayButtonPressed()
    {
        SceneManager.LoadScene(1);
    }
}
