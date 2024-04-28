using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    Rigidbody2D RB;

    Vector2 movement;

    public float speed = 5f;

    public SpriteRenderer spriteRenderer;


    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        movement = new Vector2 (Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;
    }

    private void FixedUpdate()
    {
        HandleMovment();

    }


    private void HandleMovment()
    {
        //Movment Scprit for us. I have no idea how it exactly works fr fr ong ong

        RB.velocity = movement * speed;
    }


}
