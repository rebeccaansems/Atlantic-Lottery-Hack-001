using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class HighscoreTable : MonoBehaviour
{

    public Text firstName, secondName, thirdName;
    public Text firstScore, secondScore, thirdScore;

    List<KeyValuePair<string, int>> highscores;

    void Awake()
    {
        highscores = new List<KeyValuePair<string, int>>();
    }

    void Start()
    {
        for (int i = 0; i < 3; i++)
        {
            if (PlayerPrefs.HasKey("Highscore " + i))
            {
                highscores.Add(new KeyValuePair<string, int>(PlayerPrefs.GetString("Highscore " + i), PlayerPrefs.GetInt("HighscoreScore " + i)));
            }
        }

        highscores.Add(new KeyValuePair<string, int>(CharacterData.playerName, CharacterData.secondsToFinish));
        highscores.Sort((x, y) => x.Value.CompareTo(y.Value));

        for (int i=0; i<3; i++)
        {
            PlayerPrefs.SetString("Highscore " + i, highscores[i].Key??"NO ONE");
            PlayerPrefs.SetInt("HighscoreScore " + i, highscores[i].Value);
        }

        firstName.text = highscores[0].Key;
        secondName.text = highscores[1].Key;
        thirdName.text = highscores[2].Key;

        firstScore.text = highscores[0].Value.ToString();
        secondScore.text = highscores[1].Value.ToString();
        thirdScore.text = highscores[2].Value.ToString();
    }
}
