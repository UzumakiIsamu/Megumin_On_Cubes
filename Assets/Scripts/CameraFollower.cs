using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    // My aimed object (which is Megumi and Main Cube)
    public GameObject target;

    // Distance between aimed object and the camera.
    public Vector3 distance;

    // This function helps camera to follow player.
    private void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, target.transform.position + distance, 3f);
    }
}
