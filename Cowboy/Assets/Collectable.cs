using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    public GameObject door; 
    public int objectsToCollect = 3;

    private int collectedObjects = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Collectible"))
        {
            Destroy(other.gameObject); 
            collectedObjects++;

            if (collectedObjects >= objectsToCollect)
            {
                Destroy(door); 
            }
        }
    }
}