using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 3f; // Kecepatan pergerakan pemain

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // Mendapatkan input dari sumbu horizontal (kanan dan kiri)
        float moveHorizontal = Input.GetAxis("Horizontal");

        // Mendapatkan input dari sumbu vertikal (atas dan bawah)
        float moveVertical = Input.GetAxis("Vertical");

        // Mengatur kecepatan pemain
        Vector2 movement = new Vector2(moveHorizontal, moveVertical) * speed;

        // Menggerakkan pemain menggunakan Rigidbody
        rb.velocity = movement;
    }
}

