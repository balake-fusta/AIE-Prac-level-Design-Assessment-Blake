using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

public class RSPoint2 : MonoBehaviour
{
    [SerializeField] private Transform startingSpawnPoint;

    private Vector3 currentSpawnPosition;
    public GameObject CheckpointPopup;

    private void Start()
    {
        currentSpawnPosition = startingSpawnPoint.position;
        CheckpointPopup.SetActive(false);
    }

    public void SetCheckpoint(Vector3 newCheckpoint)
    {
        currentSpawnPosition = newCheckpoint;
        Checkpoint();
    }

    public void Respawn()
    {
        PlayerMovementTutorial controller = GetComponent<PlayerMovementTutorial>();

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


    public async Task Checkpoint()
    {
        CheckpointPopup.SetActive(true);

        await Task.Delay(5000);

        CheckpointPopup.SetActive(false);


    }
}