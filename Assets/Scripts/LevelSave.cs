using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelSave : MonoBehaviour
{
    
    void Start()
    {
        //PlayerPrefs.DeleteAll();
        if(PlayerPrefs.HasKey("LevelSaved"))
        {

            int levelToLoad = PlayerPrefs.GetInt("LevelSaved");
            SceneManager.LoadScene(levelToLoad);
        }
    }

}
