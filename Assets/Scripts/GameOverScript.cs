using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScript : NumberHolder
{
    public GameObject gameOverPopUp;
    private void Start()
    {
        totalLetter.text = totalLetterValue.ToString();
        gameOverPopUp.SetActive(false);
    }

    void Update()
    {
        if (totalLetterValue <= 0)
        {
            Destroy(totalLetter);
            gameOverPopUp.SetActive(true);
            Time.timeScale = 0;
            Destroy(arrow);
        }
    }

    public void restartButton()
    {
         SceneManager.LoadScene("Level1");
    }
}
