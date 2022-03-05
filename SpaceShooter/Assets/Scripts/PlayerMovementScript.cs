using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{
    private Vector3 moveInput;
    private Rigidbody rb;
    [SerializeField] private float speed = 4f;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        MovePlayer();
    }

    // Limits player to X and Y movement.

    void Update()
    {
        moveInput = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
    }

    public void MovePlayer()
    {
        Vector3 directionX = transform.right.normalized * moveInput.x;
        Vector3 directionY = transform.up.normalized * moveInput.y;

        rb.velocity = new Vector3(0, 0, rb.velocity.z) + (directionX + directionY) * speed;
    }
}
