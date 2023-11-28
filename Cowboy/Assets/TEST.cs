using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TEST : MonoBehaviour
{
    public GameObject grapplingHookPrefab;
    public LayerMask attachLayer;

    private GameObject currentHook;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(mousePosition, Vector2.zero, Mathf.Infinity, attachLayer);

            if (hit.collider != null)
            {
                AttachGrapplingHook(hit.point);
            }
        }
    }

    void AttachGrapplingHook(Vector3 attachPoint)
    {
        if (currentHook != null)
        {
            Destroy(currentHook);
        }

        currentHook = Instantiate(grapplingHookPrefab, attachPoint, Quaternion.identity);
    }
}