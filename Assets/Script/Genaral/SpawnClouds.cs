using UnityEngine;

public class SpawnClouds : MonoBehaviour
{
    public  Transform[] SpawnCoinsTrans;
    [SerializeField] GameObject[] Clouds;
    [SerializeField] GameObject Coins;
    [SerializeField] float spawnCountClouds = 3.5f;
    [SerializeField] float spawnCountCoins = 1f;
    GameObject obstacle1; 

    void Start()
    {
          InvokeRepeating("SpawnCloud", spawnCountClouds, spawnCountClouds);
          InvokeRepeating("SpawnCoins", spawnCountCoins, spawnCountCoins);
    }
    void SpawnCloud()
    {
         int spawnIndex = Random.Range(0, SpawnCoinsTrans.Length);
         int objectIndex = Random.Range(0, Clouds.Length);     
         Destroy(Instantiate(Clouds[objectIndex], SpawnCoinsTrans[spawnIndex].position,Quaternion.identity),15f);
    }

    void SpawnCoins()
    {
         int spawnIndex = Random.Range(0, SpawnCoinsTrans.Length);
         Destroy(Instantiate(Coins, SpawnCoinsTrans[spawnIndex].position,Quaternion.identity), 8f);
    }
}
