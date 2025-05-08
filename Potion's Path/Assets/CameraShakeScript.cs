using UnityEngine;
using System.Collections;

/*public class CameraShakeScript : MonoBehaviour
{
    public static CameraShakeScript instance;
    public Transform playerCam;

    void Start()
    {
        instance = this;
    }

    public void ShakeCamera(float duration, float size)
    {
        StartCoroutine(Shake(duration, size));
        
    }

    IEnumerator Shake(float duration, float size)
    {
        float elapsedTime = 0f;
        Vector2 originalPosition = playerCam.localPosition;

        while(elapsedTime < duration)
        {
            float x = Random.Range(-1f, 1f) * size;
            float y = Random.Range(-1f, 1f) * size;

            Vector2 position = new Vector2(x, y);
            /* linearly interpolates between a and b by t (estimates unknown value between x and y)
            formula: y = y1 + ((x - x1) * (y2 - y1)) / (x2 - x1) 
            playerCam.localPosition = Vector2.Lerp(playerCam.localPosition, position, Time.deltaTime * 5f); 

            elapsedTime += Time.deltaTime;

            yield return null;
        }

        while(Vector2.Distance(playerCam.position, originalPosition) > .01f)
        {
            playerCam.localPosition = Vector2.Lerp(playerCam.localPosition, originalPosition, Time.deltaTime * 2f);

            yield return null;
        }
        playerCam.localPosition = originalPosition;
    }
}*/
