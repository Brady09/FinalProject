using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrapplingHook : MonoBehaviour
{
    public float speed = 20f;
    private Rigidbody2D rb;
    private bool isAttached = false;
    private GameObject player;
    private Vector2 initialPosition;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player");
    }

    public void ShootHook(Vector2 direction)
    {
        rb.velocity = direction * speed;
    }

    void Update()
    {
        if (isAttached)
        {
            Vector2 playerToHook = (Vector2)transform.position - (Vector2)player.transform.position;
            Vector2 perpendicularDirection = new Vector2(-playerToHook.y, playerToHook.x).normalized;
            rb.velocity = perpendicularDirection * speed;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("GrapplePoint"))
        {
            isAttached = true;
            rb.velocity = Vector2.zero;
            initialPosition = transform.position;
        }
    }

    public void Detach()
    {
        isAttached = false;
        transform.position = initialPosition;
    }
}