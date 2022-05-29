using UnityEngine;

public class BallCollision : MonoBehaviour
{
    [SerializeField] GameObject PanelLose;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.CompareTag("Obstacle"))
        {
            Player.Test = 0;
            PanelLose.SetActive(true);

            //Admobe.instance.showIntersialAdGameOver();
            AdsManager.instance.showAd();
        }
    }
}