using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] GameObject Player;

    // Update is called once per frame
    void FixedUpdate()
    {
        GameObject camera = Player;
        transform.position = camera.transform.position + new Vector3(0,0,-10);
    }
}
