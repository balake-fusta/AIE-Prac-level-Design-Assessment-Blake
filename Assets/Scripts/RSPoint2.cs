using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RSPoint2 : MonoBehaviour
{

    public Transform Player;
    public Transform SpawnPoint;
    
    // Start is called before the first frame update
    void Start()
    {
        Player.transform.position = SpawnPoint.transform.position;
        
    }

    public void respawn()
    {
        Player.position = SpawnPoint.position;
    }
}
