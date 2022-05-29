using UnityEngine;
using System.Collections;

public class EndLessLevelBonus : MonoBehaviour
{
    [SerializeField] Transform[] SpawnPoints;
    [SerializeField] GameObject[] Enemy;
    [SerializeField] float Time = 10;
    void Start()
    {
        for (int i = 0; i < SpawnPoints.Length; i++)
        {
            SpawnPoints[i].transform.position = new Vector3(SpawnPoints[i].transform.position.x, SpawnPoints[i].transform.position.y, 0);
        }
        StartCoroutine(ObstacleSpawn());
    }
    IEnumerator ObstacleSpawn()
    {
        int spawnIndex = Random.Range(0, SpawnPoints.Length);

        if (spawnIndex == 0)
        {
            Destroy(Instantiate(Enemy[0], SpawnPoints[spawnIndex].position, Enemy[0].gameObject.transform.rotation), 15f);
        }
        else
        {
            Destroy(Instantiate(Enemy[1], SpawnPoints[spawnIndex].position, Enemy[1].gameObject.transform.rotation), 15f);
        }
        yield return new WaitForSeconds(Time);
        StartCoroutine(ObstacleSpawn());
    }

    private void Update()
    {
        if ( Player.CountCoinsEndlessLevel > 5 )
        {
            Time = 3;
        }
    }
}
