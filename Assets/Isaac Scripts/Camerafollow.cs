using UnityEngine;

public class Camerafollow : MonoBehaviour

{
    public Transform target;

    public Vector3 offset;

    void LateUpdate()
    {
        transform.position = target.position + offset;
    }
}