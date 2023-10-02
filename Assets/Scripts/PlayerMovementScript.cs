using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{
    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(Input.GetAxis("Horizontal") * 0.02f, Input.GetAxis("Vertical") * 0.02f, 0);
    }
}