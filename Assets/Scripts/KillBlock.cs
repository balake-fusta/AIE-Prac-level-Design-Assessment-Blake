using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class KillBlock : MonoBehaviour
{
    public RSPoint2 RSpawn;

    // when the player hits the kill block the plyers psoition is changed to the spawnPoint  
    private void OnTriggerEnter(Collider other)
    {
        RSpawn.Respawn();
    }
}
