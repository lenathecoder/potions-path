using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject spawnItem;
    void Start()
    {
        Spawn();
        InvokeRepeating("Spawn", 1.0f, 1.0f);
    }

    void Update()
    {

    }

    void Spawn()
    {
        int spawnPointIndex = Random.Range(0,spawnPoints.Length);
        Instantiate(spawnItem, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
    }
}
