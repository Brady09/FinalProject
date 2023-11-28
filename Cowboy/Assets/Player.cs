using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Player : MonoBehaviour
{
    public Sprite leftGroundedSprite;
    public Sprite rightGroundedSprite;
    public Sprite leftNotGroundedSprite;
    public Sprite rightNotGroundedSprite;

    public LayerMask layerMask;
    public float raycastDistance = 1f;

    private SpriteRenderer spriteRenderer;
    private Camera mainCamera;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        mainCamera = Camera.main;
    }

    void Update()
    {
        Vector3 mousePosition = Input.mousePosition;
        Vector3 mousePositionInWorld = mainCamera.ScreenToWorldPoint(mousePosition);

        bool isGrounded = Physics2D.Raycast(transform.position, Vector2.down, raycastDistance, layerMask);

        if (mousePositionInWorld.x < transform.position.x) // Mouse on the left side of the player
        {
            if (isGrounded)
            {
                spriteRenderer.sprite = leftGroundedSprite;
            }
            else
            {
                spriteRenderer.sprite = leftNotGroundedSprite;
            }
        }
        else
        {
            if (isGrounded)
            {
                spriteRenderer.sprite = rightGroundedSprite;
            }
            else
            {
                spriteRenderer.sprite = rightNotGroundedSprite;
            }
        }
    }
}
