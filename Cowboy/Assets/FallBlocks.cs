using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallBlocks : MonoBehaviour
{
    private float fallSpeed = 9.8f;
    private Vector3 initialPosition;

    private void Start()
    {
        initialPosition = transform.position;
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Vector3 currentPos = transform.position;
            currentPos.y -= fallSpeed * Time.deltaTime;
            transform.position = currentPos;
        }
    }
}