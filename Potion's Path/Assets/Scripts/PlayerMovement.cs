using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private float speed = 10;
    private Rigidbody2D body;
    private bool grounded;
    private Animator anim;

    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
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
    }
}
