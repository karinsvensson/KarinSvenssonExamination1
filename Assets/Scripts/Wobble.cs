using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wobble : MonoBehaviour
{
    void FixedUpdate()
    {
        // should probably make it so the things cant look bad
        float randomScale = Random.Range(-.002f, .002f);
        transform.localScale = transform.localScale += new Vector3(randomScale, randomScale, randomScale);
    }
}
