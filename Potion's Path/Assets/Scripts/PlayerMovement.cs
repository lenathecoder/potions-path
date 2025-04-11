using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
<<<<<<< HEAD
    private float speed = 10;
=======
    private float speed=10;
>>>>>>> 2fc833ac59b6ba69f4c9da737a94c150a2eeded0
    private Rigidbody2D body;
    private bool grounded;

    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
<<<<<<< HEAD
        body.linearVelocity = new Vector2(Input.GetAxis("Horizontal")*speed, body.linearVelocity.y);

        if(Input.GetKey(KeyCode.Space))
            body.linearVelocity = new Vector2(body.linearVelocity.x, speed);
=======
        float horizontalInput = Input.GetAxis("Horizontal");
        body.linearVelocity = new Vector2(horizontalInput*speed, body.linearVelocity.y);

        //Flip player when moving left to right
        if(horizontalInput > .01f)
            transform.localScale = new Vector3(1, 1, 1);
        if(horizontalInput<-.01f)
            transform.localScale = new Vector3(-1, 1, 1);

        if(Input.GetKey(KeyCode.Space))
            Jump();
    }

    private void Jump()
    {
        body.linearVelocity = new Vector2(body.linearVelocity.x, speed);
        grounded = false;
>>>>>>> 2fc833ac59b6ba69f4c9da737a94c150a2eeded0
    }
}
