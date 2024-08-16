using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomCursor : MonoBehaviour
{
    public SpriteRenderer cursorSpriteRenderer; // Reference to the SpriteRenderer component
    public Sprite customCursorSprite; // Assign your custom cursor sprite here in the Inspector

    void Start()
    {
        // Hide the system cursor
        Cursor.visible = false;

        // Assign the custom sprite to the SpriteRenderer
        if (cursorSpriteRenderer != null && customCursorSprite != null)
        {
            cursorSpriteRenderer.sprite = customCursorSprite;
        }
    }

    void Update()
    {
        // Update the position of the cursor to match the mouse position
        Vector2 cursorPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = cursorPosition;
    }
}