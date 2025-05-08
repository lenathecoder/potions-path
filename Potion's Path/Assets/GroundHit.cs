using UnityEngine;

public class GroundHit : MonoBehaviour
{
    // Our components
    private BoxCollider2D boxCollider;
    Rigidbody2D _rb; //Creat contrainer for our rigidbody


    private void OnCollisionEnter2D(Collision2D collision)

    {
        if (collision.gameObject.tag == "hitLayer")
        {
            transform.position = new Vector2(-50.68f, -1.21f);
        }
    }

}
