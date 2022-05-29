using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    int nextSceneLoad;

    private void Start()
    {
        nextSceneLoad = SceneManager.GetActiveScene().buildIndex + 1;
    }
    public void ButtonRestart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void ButtonNextLevel()
    {
        if (SceneManager.GetActiveScene().buildIndex == 9) 
        {
            SceneManager.LoadScene("Win");
        }
        else
        {
            SceneManager.LoadScene(nextSceneLoad);
            if (nextSceneLoad > PlayerPrefs.GetInt("levels"))
            {
                PlayerPrefs.SetInt("levels", nextSceneLoad);               
            }
        }
    }
    public void ButtonMenuLevel()
    {
        SceneManager.LoadScene("LevelMenu");
    }
}
