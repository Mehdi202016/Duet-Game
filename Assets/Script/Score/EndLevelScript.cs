using UnityEngine;

public class EndLevelScript : MonoBehaviour
{
    [SerializeField] GameObject Panel_win;
    [SerializeField] int LevelIndex;

    private void OnTriggerEnter2D(Collider2D other)
    {
        //hada dial stars
        if (other.CompareTag("pl"))
        {
            Player.Test = 0;
            Panel_win.SetActive(true);
            Debug.Log("Mission Complet");
            if (Player.StarsCount > PlayerPrefs.GetInt("Lve" + LevelIndex))
            {
                PlayerPrefs.SetInt("Lve" + LevelIndex, Player.StarsCount);
            }
        }
    }
}
