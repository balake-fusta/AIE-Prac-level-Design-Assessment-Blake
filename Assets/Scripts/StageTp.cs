using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageTp : MonoBehaviour
{
    public Transform Player;
    public Transform tpPoint1;

    private void OnTriggerEnter(Collider other)
    {
        Player.transform.position = tpPoint1.transform.position;
    }
}

