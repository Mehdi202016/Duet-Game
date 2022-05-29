using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour
{
    [SerializeField] Text scoreText_win;
    [SerializeField] Text LevelText_win;
    [SerializeField] Text scoreText_lose;
    [SerializeField] Text LevelText_lose;
    [SerializeField] Text score;
    

    void Update()
    {
        string nameLevel = SceneManager.GetActiveScene().name;

        scoreText_win.text = Player.CountCoinsEndlessLevel.ToString();
        LevelText_win.text = nameLevel;

        scoreText_lose.text = Player.CountCoinsEndlessLevel.ToString();
        LevelText_lose.text = nameLevel;
        
        score.text=Player.CountCoinsEndlessLevel.ToString();
    }
}
