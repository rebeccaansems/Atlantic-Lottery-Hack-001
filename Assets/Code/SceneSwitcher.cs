using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class SceneSwitcher : MonoBehaviour
{
    public GameObject pauseScreen;
    public Sprite pauseSprite;
    public InputField nameField;

    void Update()
    {
        if(SceneManager.GetActiveScene().buildIndex == 2)
        {
            if (Input.GetKeyDown((KeyCode.Escape)) || Input.GetKeyDown((KeyCode.P)))
            {
                if (Time.timeScale == 0)
                {
                    Time.timeScale = 1;
                    pauseScreen.GetComponent<SpriteRenderer>().sprite = null;
                }
                else if (SceneManager.GetActiveScene().buildIndex == 2)
                {
                    Time.timeScale = 0;
                    pauseScreen.GetComponent<SpriteRenderer>().sprite = pauseSprite;
                }
            }
            else if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(1);
            }
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            Application.Quit();
        }
    }

    public void MainMenuPlayButtonPressed()
    {
        SceneManager.LoadScene(1);
    }

    public void GameOverEnterButtonPressed()
    {
        CharacterData.playerName = nameField.text ?? "Anonymous";
        SceneManager.LoadScene(4);
    }

    public void HighscoreContinueButtonPressed()
    {
        SceneManager.LoadScene(0);
    }
}
