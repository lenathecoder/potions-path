using UnityEngine;

public class ShakeScript : MonoBehaviour
{
 
    // Update is called once per frame
    [SerializeField] private LayerMask hitLayer;
    private BoxCollider2D boxCollider;
    Rigidbody2D _rb;
    public CameraShake shaker;

    public void Start()
    {
        //Assign the RigidBody2D to our container
        _rb = gameObject.GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "hitLayer")
        {
            //SHAKE SCRIPT
            StartCoroutine(shaker.Shake(.15f, .4f));
        }
    }
}