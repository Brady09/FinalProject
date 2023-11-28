using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchObject : MonoBehaviour
{
    public float launchForce = 10f; // Adjust this value to control the launch force

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // Change "Player" to the tag of your player GameObject
        {
            Rigidbody2D playerRb = other.GetComponent<Rigidbody2D>();
            if (playerRb != null)
            {
                playerRb.velocity = Vector2.zero; // Reset the current velocity to prevent interference
                playerRb.AddForce(Vector2.up * launchForce, ForceMode2D.Impulse);
            }
        }
    }
}