using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMovement : MonoBehaviour
{
    [SerializeField] bool Variety1;
    [SerializeField] bool Variety2;
    private void FixedUpdate()
    {
        if(Variety1 == true)
        {
            transform.position = transform.position + new Vector3(Random.Range(-.05f, .05f), Random.Range(-.05f, .05f), Random.Range(0, 0));
            float randomScale = Random.Range(-.002f, .002f);
            transform.localScale = transform.localScale += new Vector3(randomScale, randomScale, randomScale);
        }

        if(Variety2 == true)
        {
            transform.position = transform.position + new Vector3(Random.Range(-.02f, .02f), Random.Range(-.02f, .02f), Random.Range(0, 0));
        }
    }
}