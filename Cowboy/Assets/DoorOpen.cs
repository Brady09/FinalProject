using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    public GameObject objectToDelete;

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the colliding object is the one you want
        
       
            Destroy(objectToDelete);
        
    }
}