using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bmove : MonoBehaviour
{
    private Rigidbody2D rb;
    private float horizontalMove;
    public float hspeed = 5;
    private bool moveLeft;
    private bool moveRight;
    private bool moveUp;
    private bool moveDown;
    private float verticalMove;
    public float vspeed = 5;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        moveLeft = false;
        moveRight = false;
        moveUp = false;
        moveDown = false;
    }

    //I am pressing the left button
    public void PointerDownLeft()
    {
        moveLeft = true;
    }

    //I am not pressing the left button
    public void PointerUpLeft()
    {
        moveLeft = false;
    }

    //Same thing with the right button
    public void PointerDownRight()
    {
        moveRight = true;
    }

    public void PointerUpRight()
    {
        moveRight = false;
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
        MovementPlayer();

        VMovementPlayer();

        // Flip the character
        Vector3 characterScale = transform.localScale;
        if (moveRight == true)
        {
            characterScale.x = 1;
        }
        if (moveLeft == true)
        {
            characterScale.x = -1;
        }
        transform.localScale = characterScale;
    }

    //Now let's add the code for moving
    private void MovementPlayer()
    {
        //If i press the left button
        if (moveLeft)
        {
            horizontalMove = -hspeed;
        }

        //if i press the right button
        else if (moveRight)
        {
            horizontalMove = hspeed;
        }

        //if i am not pressing any button
        else
        {
            horizontalMove = 0;
        }
    }

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
        rb.velocity = new Vector2(horizontalMove, verticalMove);
    }
}
