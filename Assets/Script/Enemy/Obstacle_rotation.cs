using UnityEngine;

public class Obstacle_rotation : MonoBehaviour
{
    [SerializeField] float speed=300;
    void Update()
    {
        transform.Rotate(new Vector3(0,0,speed*Time.fixedDeltaTime));
    }
}
