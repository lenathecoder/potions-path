using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    Vector2 camInitialPos;
    private float shakeMagnitude = .05f;
    private float shakeTime = .5f;
    public void Start()
    {
        camInitialPos = mainCamera.transform.position;
        InvokeRepeating(Shake(), 0f, .005f);
        StopShake();
    }

    // Update is called once per frame
    public void Shake()
    {
        float cameraShakingOffsetX = Random.value * shakeMagnitude * 2 - shakeMagnitude;
        float cameraShakingOffsetY = Random.value * shakeMagnitude * 2 - shakeMagnitude;
        Vector2
    }

    public void StopShake()
    {

    }
}
