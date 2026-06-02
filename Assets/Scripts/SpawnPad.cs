using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPad : MonoBehaviour
{
    public Transform spawnPad;
    public Transform spawnPoint;
    public GameObject checkpointPopUp;
    public float checkpointShowTime;

    private void Start()
    {
        checkpointPopUp.SetActive(false);
    }

    private void Update()
    {


    }
    private void OnTriggerEnter(Collider other)
    {
       
            spawnPoint.transform.position = spawnPad.transform.position;
        checkpointPopUp.SetActive(true);
        StartCoroutine("waitForSec");
        Debug.Log("jsjfif");
    }

    IEnumerator waitForSec()
    {
        yield return new WaitForSeconds(checkpointShowTime);
        checkpointPopUp.SetActive(false);
    }
}
