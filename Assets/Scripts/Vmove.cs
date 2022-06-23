using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vmove : MonoBehaviour
{
    private Rigidbody2D rb;
    private bool moveUp;
    private bool moveDown;
    private float verticalMove;
    public float vspeed = 5;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        moveUp = false;
        moveDown = false;
    }

    //I am pressing the up button
    public void PointerDownUp()
    {
        moveUp = true;
    }

    //I am not pressing the up button
    public void PointerUpUp()
    {
        moveUp = false;
    }

    //Same thing with the down button
    public void PointerDownDown()
    {
        moveDown = true;
    }

    public void PointerUpDown()
    {
        moveDown = false;
    }

    // Update is called once per frame
    void Update()
    {
        VMovementPlayer();
    }

    //Now let's add the code for moving
    private void VMovementPlayer()
    {
        //If i press the up button
        if (moveUp)
        {
            verticalMove = vspeed;
        }

        //if i press the down button
        else if (moveDown)
        {
            verticalMove = -vspeed;
        }

        //if i am not pressing any button
        else
        {
            verticalMove = 0;
        }
    }

    //add the movement force to the player
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(0.0f, verticalMove);
    }
}