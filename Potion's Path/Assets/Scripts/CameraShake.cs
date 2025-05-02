using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    Vector2 camInitialPos;
    public float shakeMagnitude = .05f;
    public float shakeTime = .5f;
    public Camera mainCamera;

    public void Start()
    {
        camInitialPos = mainCamera.transform.position;
        InvokeRepeating("Shake", 0f, .005f);
        Invoke("StopShake", shakeTime);
    }

    public void Shake()
    {
        float cameraShakingOffsetX = Random.value * shakeMagnitude * 2 - shakeMagnitude;
        float cameraShakingOffsetY = Random.value * shakeMagnitude * 2 - shakeMagnitude;
        Vector2 camPosition = mainCamera.transform.position;

        camPosition += cameraShakingOffsetX;
        camPosition += cameraShakingOffsetY;

        mainCamera.transform.position = camPosition;
    }

    public void StopShake()
    {
        CancelInvoke("Shake");
        mainCamera.transform.position = camInitialPos;
    }
}
