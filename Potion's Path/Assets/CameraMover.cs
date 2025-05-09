using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class CameraMover : MonoBehaviour
{
    // Our components
    private BoxCollider2D boxCollider;
    Rigidbody2D _rb;
    public Image Image1;
    public Image Image2;

    private void Start()
    {
        Image1.gameObject.SetActive(true);
        _rb = GetComponent<Rigidbody2D>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "platform")
        {
            Image1.gameObject.SetActive(false);
            Image2.gameObject.SetActive(true);
            transform.position = new Vector2(-50.68f, -1.21f);
        }

        if(collision.gameObject.tag == "platform2")
        {
            SceneManager.LoadScene("Gazebo");
        }
    }
}
