using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seek : MonoBehaviour
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
        else
        {
            // Handle the case where the "Player" GameObject is not found.
            // You can log an error message or take other appropriate action.
        }
    }

}
