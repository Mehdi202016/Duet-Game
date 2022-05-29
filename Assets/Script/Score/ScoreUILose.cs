using UnityEngine;
using UnityEngine.UI;

public class ScoreUILose : MonoBehaviour
{
    [SerializeField] Text scoreText_lose;
    [SerializeField] Text score;

    void Update()
    {
        scoreText_lose.text = Player.CountCoinsEndlessLevel.ToString();
        score.text = Player.CountCoinsEndlessLevel.ToString();
    }
}
