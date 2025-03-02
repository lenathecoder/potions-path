using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float speed;
    private Rigidbody2D body;

    private void Awake()
    {
        body = GetComponent<Rigidbody2D();
    }

    private void Update()
    {
        body.linearvelocity = new Vector2(Input.GetAxis("Horizontal")*speed, body.linearvelocity.y);

        if(Input.GetKey(KeyCode.Space))
            body.linearvelocity = new Vector2(body.linearvelocity.x, speed);
    }
}
