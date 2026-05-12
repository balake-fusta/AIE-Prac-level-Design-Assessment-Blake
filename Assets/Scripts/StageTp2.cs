using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageTp2 : MonoBehaviour
{
    public Transform Player;
    public Transform tpPoint2;

    private void OnTriggerEnter(Collider other)
    {
        Player.transform.position = tpPoint2.transform.position;
    }
}

