using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] Transform Player;
     [SerializeField] Transform spawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        Player.transform.position = spawnPoint.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        Player.transform.position = spawnPoint.transform.position;
    }
}
