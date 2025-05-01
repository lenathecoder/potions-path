using UnityEngine;

public class CountdownTimer : MonoBehaviour
{
    public string levelToLoad;
    private float timer = 10f;

    void Update()
    {
        timer -= timer.deltaTime;
        if(timer <= 0)
        {
            Application.LoadLevel(levelToLoad);
        }
    }
}
