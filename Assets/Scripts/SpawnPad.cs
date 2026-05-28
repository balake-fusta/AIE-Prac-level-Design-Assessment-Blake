using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPad : MonoBehaviour
{
    public Transform spawnPad;
    public Transform spawnPoint;
    public GameObject checkpointPopUp;

    private void Start()
    {
        checkpointPopUp.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
            spawnPoint.transform.position = spawnPad.transform.position;
        checkpointPopUp.SetActive(true);
        Debug.Log("jsjfif");

    }
    /*public void OnTriggerStay(Collider other)
    {
        if (checkpointPopUp.SetActive = true)
        {

        }
    }
    */
    
}
