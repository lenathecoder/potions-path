using UnityEngine;
using UnityEngine.SceneManagement;

public class FairyHit : MonoBehaviour
{
    // Our components
    [SerializeField] private LayerMask groundLayer;
    private BoxCollider2D boxCollider;
    Rigidbody2D _rb; //Creat contrainer for our rigidbody


    public void Start()
    {
        //Assign the RigidBody2D to our container
        _rb = gameObject.GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)

    {
        if (collision.gameObject.tag == "Branch")
        {
            transform.position = new Vector2(-9.4f, -2.83f);
            GameManager2.health -= 1;
        }
    }

}

