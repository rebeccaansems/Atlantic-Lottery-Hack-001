using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class SceneSwitcher : MonoBehaviour {

	public void MainMenuPlayButtonPressed()
    {
        SceneManager.LoadScene(1);
    }

    public void GameOverEnterButtonPressed()
    {
        SceneManager.LoadScene(0);
    }
}
