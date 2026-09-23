using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public RSPoint2 rSPoint2;
    private void OnTriggerEnter(Collider other)
    {
        
            rSPoint2.SetCheckpoint(transform.position);

            Debug.Log("Checkpoint Reached");
        
    }
}