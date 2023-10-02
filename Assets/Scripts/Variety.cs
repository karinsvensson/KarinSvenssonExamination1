using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variety : MonoBehaviour
{

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = transform.position + new Vector3(Random.Range(-.05f,.05f), Random.Range(-.05f,.05f), Random.Range(0,0));
    }
}
