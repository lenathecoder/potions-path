using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject spawnItem;
    [SerializeField] private LayerMask groundLayer;
    Rigidbody2D _rb;
    //private float timeLeft = 10f;
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        Spawn();
        InvokeRepeating("Spawn", 1.0f, 1.0f);
    }

    /*private void OnCollisionEnter2D(Collision2D collision)

    {
        if (collision.gameObject.tag == "Ground")
        {
            timeLeft -= Time.deltaTime;
            if(timeLeft < 0)
            {
                spawnItem.gameObject.SetActive(false);
            }
        }
    }*/

    void Spawn()
    {
        int spawnPointIndex = Random.Range(0,spawnPoints.Length);
        Instantiate(spawnItem, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
    }
}
