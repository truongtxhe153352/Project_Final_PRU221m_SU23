using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    public float jumpForce;
    public float timeToJump;
    private float jumpTimeCounter;

    //setting game faster and faster
    public float speedIncrease;
    private float speedIncreaseMilestoneStore;


    private float speedCount;
    public float speedMultipler;

    private Rigidbody2D myRigidbody;

    public bool grounded;
    public LayerMask whatIsGround;
    public Transform groundCheck;
    public float groundCheckRadius;

    public float moveSpeedStore;
    // private Collider2D myCollider;
    private float speedMilestoneCountStore;

    private Animator myAnimator;

    public GameManager gameManager;

    private bool stoppedJumping;
    //private bool canDoubleJumping;

    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        // myCollider = GetComponent<Collider2D>();
        myAnimator = GetComponent<Animator>();
        jumpTimeCounter = jumpForce;
        speedCount = speedIncrease;

        moveSpeedStore = moveSpeed;
        speedMilestoneCountStore = speedCount;
        speedIncreaseMilestoneStore = speedIncrease;

        stoppedJumping = true;
    }

    void Update()
    {
        //grounded = Physics2D.IsTouchingLayers(myCollider, whatIsGround);
        grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);


        if (transform.position.x > speedCount)
        {
            speedCount += speedIncrease;
            speedIncrease += speedIncrease * speedMultipler;
            moveSpeed = moveSpeed * speedMultipler;
        }


        myRigidbody.velocity = new Vector2(moveSpeed, myRigidbody.velocity.y);


        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            if (grounded)
            {
                myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, jumpForce);
                stoppedJumping = false;
            }
            //if (!grounded && canDoubleJumping)
            //{
            //    myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, jumpForce);
            //    stoppedJumping = false;
            //    canDoubleJumping = false;
            //}
        }

        if ((Input.GetKey(KeyCode.Space) || Input.GetMouseButton(0)) && !stoppedJumping)
        {
            if (jumpTimeCounter > 0)
            {
                myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, jumpForce);
                jumpTimeCounter -= Time.deltaTime;
            }
        }

        if (Input.GetKeyUp(KeyCode.Space) || Input.GetMouseButtonUp(0))
        {
            jumpTimeCounter = 0;
            stoppedJumping = true;
        }

        if (grounded)
        {
            jumpTimeCounter = timeToJump;
           // canDoubleJumping = true;
        }

        myAnimator.SetFloat("Speed", myRigidbody.velocity.x);
        myAnimator.SetBool("Grounded", grounded);
    }

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (collision.gameObject.tag == "killbox")
    //    {
    //        gameManager.restartGame();
    //        moveSpeed = moveSpeedStore;
    //        speedCount = speedMilestoneCountStore;
    //        speedIncrease = speedIncreaseMilestoneStore;
    //    }
    //}
}
