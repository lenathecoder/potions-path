using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameManager2 : MonoBehaviour
{
    public GameObject gameOver, heart0, heart1, heart2;
    public static int health;

    void Start()
    {
        health = 3;
        heart0.gameObject.SetActive(true);
        heart1.gameObject.SetActive(true);
        heart2.gameObject.SetActive(true);
        gameOver.gameObject.SetActive(false);
    }

    void Update()
    {
        switch (health)
        {
            case 3:
                heart0.gameObject.SetActive(true);
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(true);
                break;
            case 2:
                heart0.gameObject.SetActive(true);
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(false);
                break;
            case 1:
                heart0.gameObject.SetActive(true);
                heart1.gameObject.SetActive(false);
                heart2.gameObject.SetActive(false);
                break;
            default:
                heart0.gameObject.SetActive(false);
                heart1.gameObject.SetActive(false);
                heart2.gameObject.SetActive(false);
                gameOver.gameObject.SetActive(true);
                Time.timeScale = 0;
                break;
        }
    }
}
