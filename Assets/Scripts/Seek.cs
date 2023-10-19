using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seek : MonoBehaviour
{
    Spawn spawn;
   // [SerializeField] GameObject Player;
    [SerializeField] float power;

    private void Awake()
    {
        GameObject player = GameObject.Find("Player");
        spawn = player.GetComponent<Spawn>();
    }

    void FixedUpdate()
    {
        GameObject moveTowardsThis = spawn.Player;
        transform.position = Vector3.MoveTowards(transform.position, moveTowardsThis.transform.position, power);
    }
}
