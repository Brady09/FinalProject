using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    public GameObject doorToDelete; 
    public int requiredCollectibles = 3; 

    private int collectedCount = 0; 
    
    private void OnTriggerEnter2D(Collider other)
    {
        Collect();
    }

    private void Collect()
    {
        collectedCount++;

        if (collectedCount >= requiredCollectibles)
        {
            DestroyDoor();
        }
        Destroy(this.gameObject); 
    }

    private void DestroyDoor()
    {
        if (doorToDelete != null)
        {
            Destroy(doorToDelete);
        }
    }
}