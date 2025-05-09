using UnityEngine;
using UnityEngine.SceneManagement;

public class GameRespawn : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SceneManager.LoadScene("Level1");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
