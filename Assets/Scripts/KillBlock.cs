using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillBlock : MonoBehaviour
{
    public Transform Player;
    public Transform spawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        //when games starts the players position is set to the SpawnPoint
        Player.transform.position = spawnPoint.transform.position;
    }

    // when the player hits the kill block the plyers psoition is changed to the  
    private void OnTriggerEnter(Collider other)
    {
        Player.transform.position = spawnPoint.transform.position;
    }
}
