/*
     hmwk4_scampbell48_Player.cs
    
     Sean Campbell
     Account: scampbell48
     CSc 4821
     Homework 4
     Due date: 11/19
    
     Description:
         Hnadles Player animation, movement, and inputs
     Input:
         Left, right and down arrow keys
     Output:
         Moves player position, manages it's animation
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Animator anim;
    public SpriteRenderer sprite;
    public Rigidbody2D rb;

    public float speed;
    public float jumpStrength;

    private void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    void Update()
    {
        //Resets animation state when no movement
        if (rb.velocity.x == 0)
        {
            anim.SetBool("Moving", false);
        }
        if (rb.velocity.y == 0)
        {
            anim.SetBool("Jump", false);
        }
        //Sets animation and moves player
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            sprite.flipX = true;
            anim.SetBool("Moving", true);

            Move(-1);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            sprite.flipX = false;
            anim.SetBool("Moving", true);

            Move(1);
        }
        //Makes Player jump
        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetBool("Jump", true);

            Jump();
        }
    }
    //Takes a direction to add a force to move the player
    void Move(int dir)
    {

        Vector2 movement = new Vector2(dir * speed, 0);
        rb.AddForce(movement);
    }

    void Jump()
    {
        Vector2 jump = new Vector2(0, jumpStrength);
        rb.AddForce(jump);
    }
}
