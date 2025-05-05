using UnityEngine;
using System.Collections;

public class CameraShake : MonoBehaviour
{
    public CameraShake cameraShake;
    void Update()
    {
        StartCoroutine(.15f, .4f);
    }
    public IEnumerator Shake(float duration, float magnitude)
    {
        Vector2 originalPos = transform.localPosition;

        float elapsed = 0f;

        while(elapsed < duration)
        {
            float x = Random.Range(-1f, 1f) * magnitude;
            float y = Random.Range(-1f, 1f) * magnitude;

            transform.localPosition = new Vector2(x, y);

            elapsed += Time.deltaTime;

            yield return null;

            transform.localPosition = originalPos;
        }
    }
}
