using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public GameObject endGamePopUp;
    public static int levelSave = 0;
    public int activeScene;
    public int nextScene;
    void Start()
    {
        activeScene = SceneManager.GetActiveScene().buildIndex;
        endGamePopUp.SetActive(false);
    }

    void Update()
    {
        //Debug.Log(currentLevel);
    }
    public void levelLoad()
    {
        activeScene += 1;
        SceneManager.LoadScene(activeScene);
        PlayerPrefs.SetInt("LevelSaved", activeScene);

        Debug.Log(activeScene);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            endGamePopUp.SetActive(true);
        }

    }
}
