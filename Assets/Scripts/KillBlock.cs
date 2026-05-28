using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class KillBlock : MonoBehaviour
{
    public Transform Player;
    public Transform spawnPoint;
    

    // when the player hits the kill block the plyers psoition is changed to the spawnPoint  
    private void OnTriggerEnter(Collider other)
    {
        Player.transform.position = spawnPoint.transform.position;
    }
}
