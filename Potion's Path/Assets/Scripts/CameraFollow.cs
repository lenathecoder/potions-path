using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform[] target;
    public float  smoothSpeed = 0.125f;
    void LateUpdate()
    {
        if (target == null)
        {
            return;
        }
        Vectpr3 targetPosition = target.position;
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, refvelocity, smoothSpeed)
    }
}
    
