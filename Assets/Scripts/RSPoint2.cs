using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RSPoint2 : MonoBehaviour
{
    [SerializeField] private Transform startingSpawnPoint;

    private Vector3 currentSpawnPosition;

    private void Start()
    {
        currentSpawnPosition = startingSpawnPoint.position;
    }

    public void SetCheckpoint(Vector3 newCheckpoint)
    {
        currentSpawnPosition = newCheckpoint;
    }

    public void Respawn()
    {
        CharacterController controller = GetComponent<CharacterController>();

        // CharacterController needs to be disabled before teleporting.
        if (controller != null)
        {
            controller.enabled = false;
        }

        transform.position = currentSpawnPosition;

        if (controller != null)
        {
            controller.enabled = true;
        }
    }
}