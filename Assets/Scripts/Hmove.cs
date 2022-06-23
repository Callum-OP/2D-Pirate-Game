using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hmove : MonoBehaviour
{
    private Rigidbody2D rb;
    private bool moveLeft;
    private bool moveRight;
    private float horizontalMove;
    public float speed = 5;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        moveLeft = false;
        moveRight = false;
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

    // Update is called once per frame
    void Update()
    {
        MovementPlayer();

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
            horizontalMove = -speed;
        }

        //if i press the right button
        else if (moveRight)
        {
            horizontalMove = speed;
        }

        //if i am not pressing any button
        else
        {
            horizontalMove = 0;
        }
    }

    //add the movement force to the player
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontalMove, rb.velocity.y);
    }
}
