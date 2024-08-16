using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CroshairRender : MonoBehaviour
{
    [Header("Raycast Settings")]
    [SerializeField] private float rayLength = 10f; // The length of the raycast
    [SerializeField] private LayerMask layerMask; // The layers the raycast should detect

    [Header("References")]
    public Transform rayOrigin; // The origin of the raycast, typically your gun or camera
    public SpriteRenderer markerSpriteRenderer; // The SpriteRenderer to display the marker

    [Header("Marker Settings")]
    public Sprite markerSprite; // The PNG sprite to display at the end of the ray or on hit

    private void Start()
    {
        if (markerSpriteRenderer != null && markerSprite != null)
        {
            markerSpriteRenderer.sprite = markerSprite; // Assign the PNG sprite to the SpriteRenderer
        }
    }

    private void Update()
    {
        DisplayRaycastMarker();
    }

    void DisplayRaycastMarker()
    {
        Vector2 direction = rayOrigin.right; // Assuming the ray points right; adjust if needed
        RaycastHit2D hit = Physics2D.Raycast(rayOrigin.position, direction, rayLength, layerMask);

        if (hit.collider != null && ((1 << hit.collider.gameObject.layer) & layerMask) != 0)
        {
            // If the ray hits a collider on the grapple layer, position the marker at the hit point
            markerSpriteRenderer.transform.position = hit.point;
            markerSpriteRenderer.enabled = true; // Show the marker
        }
        else
        {
            // If no collider is hit or the hit object is not on the grapple layer, hide the marker
            markerSpriteRenderer.enabled = false;
        }
    }

    private void OnDrawGizmosSelected()
    {
        // Draw the ray in the editor for visualization
        if (rayOrigin != null)
        {
            Gizmos.color = Color.blue;
            Gizmos.DrawLine(rayOrigin.position, rayOrigin.position + (Vector3)(rayOrigin.right * rayLength));
        }
    }
}