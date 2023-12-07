using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    public GameObject objectToDelete;

    private void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(objectToDelete);  
    }
}