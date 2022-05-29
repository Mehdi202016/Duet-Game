using UnityEngine;
using System.Collections;

public class Player_animation : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(new Vector3(0, 0, 100 * Time.deltaTime));
    }
}
