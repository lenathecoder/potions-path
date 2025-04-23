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
            transform.localScale = Vector2.one;
        else if(horizontalInput<-.01f)
            transform.localScale = new Vector2(-1, 1);

        if(Input.GetKey(KeyCode.Space) && grounded)
            print (grounded);
            Jump();

        //Set run bool
        anim.SetBool("run", horizontalInput !=0 );
    }

    private void Jump()
    {
        body.linearVelocity = new Vector2(body.linearVelocity.x, speed);
        grounded = false;
    }
    
    private void OnCollisionEnter2D(Collision2D collision) {
        if(collision.gameObject.tag == "Ground")
            grounded = true;
    }

    private void RaycastHit2D Physics2D.BoxCast(Vector 2 origin, Vector 2 size, float angle, Vector2 direction, float distance){
        
    }
}
