using UnityEngine;

public class FairyHit : MonoBehaviour
{
    // Our components
    Rigidbody2D _rb; //Creat contrainer for our rigidbody

    // Our fields related to movement
    float _moveHorizontal; //Get horizontal input
    float _moveSpeed = 10f; //Out movespeed
    Vector2 _currentVelocity; //Our current velocity

    //Trigger example
    bool _canInteract = false;

    public void Start()
    {
        //Assign the RigidBody2D to our container
        _rb = gameObject.GetComponent<Rigidbody2d>();
    }

    public void Update()
    {
        //Assign the player input
        _moveHorizontal = Input.GetAxisRaw("Horizontal");

        //Assign the current speed/velocity
        _currentVelocity = new Vector2(_moveHorizontal, 0f) * _moveSpeed;

        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(_canInteract == true)
            {
                Debug.Log('Turn on light switch');
            }
        }
    }

    public void FixedUpdate()
        {
            MovePlayer();
        }


    // Create the method for player movement
    public void MovePlayer()
    {
        if (_moveHorizontal != 0) //Check for player input
        {
            _rb.linerVelocity = _currentVelocity; // Set player movement to current velocity
    
        }
        else // If standing still
        {
            // Set player movement to zero
            _currentVelocity = new Vector2(0f, 0f);
            _rb.linerVelocity = _currentVelocity;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject)
    }
}
