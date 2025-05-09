using UnityEngine;

public class BranchDisappear : MonoBehaviour
{
    Rigidbody2D _rb;
    public GameObject spawnItem;
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    
    private void OnCollisionEnter2D(Collision2D collision)

    {
        if (collision.gameObject.tag == "Ground")
        {
            spawnItem.gameObject.SetActive(false);
        }
    }
}
