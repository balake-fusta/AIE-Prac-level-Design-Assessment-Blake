using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out RSPoint2 rSPoint2))
        {
            rSPoint2.SetCheckpoint(transform.position);

            Debug.Log("Checkpoint Reached");
        }
    }
}