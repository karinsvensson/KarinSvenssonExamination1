using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirusScript : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] float power;

    void FixedUpdate()
    {
        if (player == null)
        {
            player = GameObject.Find("Player");
        }

        if (player != null)
        {
            transform.position = Vector3.MoveTowards(transform.position, player.transform.position, power);
        }
    }
}
