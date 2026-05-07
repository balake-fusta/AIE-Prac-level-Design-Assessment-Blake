using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPad : MonoBehaviour
{
    public Transform spawnPad;
    public Transform spawnPoint;

    private void OnTriggerEnter(Collider other)
    {
        spawnPoint.transform.position = spawnPad.transform.position;
    }
}
