using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    Rigidbody2D RB;

    float movementx;
    float movementy;

    public float speed = 5f;



    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();




    }

    // Update is called once per frame
    void Update()
    {
        movementx = Input.GetAxisRaw("Horizontal");
        movementy = Input.GetAxisRaw("Vertical");






    }

    private void FixedUpdate()
    {
        HandleMovment();

    }


    private void HandleMovment()
    {
        //Movment Scprit for us. I have no idea how it exactly works fr fr ong ong

        RB.velocity = new Vector2(movementx * speed, RB.velocity.y);
        RB.velocity = new Vector2(RB.velocity.x, movementy * speed);

        
    }

}
