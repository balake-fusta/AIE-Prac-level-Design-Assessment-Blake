using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPad : MonoBehaviour
{
    public RSPoint2 RSpawn;

    private void Start()
    {
        RSpawn = GetComponent<RSPoint2>();
    }
    private void OnTriggerEnter(Collider other)
    {
        RSpawn.SpawnPoint.position = gameObject.transform.position;
    }
}
