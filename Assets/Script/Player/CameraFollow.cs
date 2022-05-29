using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    Transform target;
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }
    void Update()
    {
        Time.timeScale = 1;
        if (transform.position.y <= target.position.y)
        {
            transform.position = new Vector3(transform.position.x, target.position.y ,-10f);
        }

    }
}
