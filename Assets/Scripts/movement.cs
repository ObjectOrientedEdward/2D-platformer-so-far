    


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float movementSpeed = 5;

    public float gcRadius;
    public Transform groundCheck;
    public bool onGround;
    public LayerMask Ground;
    


    void Update()
    {
        jump();
        horizontalMovement();
        sprint();
    }

    void jump()
    {
        //the following line of code (line 29) is from a youtube tutorial
        onGround = Physics2D.OverlapCircle(groundCheck.position, gcRadius, Ground);


        float jumpHeight = 6.3f;

        if (Input.GetButtonDown("Jump") && onGround)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpHeight), ForceMode2D.Impulse);
        }

    }
   
    void horizontalMovement()
    {
        float inputx = Input.GetAxis("Horizontal");
        transform.position += new Vector3(inputx, 0, 0) * movementSpeed * Time.deltaTime;
        
    }


    void sprint()
    {

        float sprintMultiplier = 1.7f;
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {   
            movementSpeed *= sprintMultiplier;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            movementSpeed /= sprintMultiplier;
        }
    }



}
