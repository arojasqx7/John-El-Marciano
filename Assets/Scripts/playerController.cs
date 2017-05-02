using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.CrossPlatformInput;

public class playerController : MonoBehaviour {

    public static playerController current;
    public ContadorDinero cont;
    public float maxSpeed;
    bool grounded = false;
    float groundCheckRadius = 0.2f;
    public LayerMask groundLayer;
    public Transform groundCheck;
    public float jumpHeight;

    Rigidbody2D myRB;
    Animator myAnim;
    bool facingRight;


    public Transform gunTip;
    public GameObject bullet;
    float fireRate = 0.5f;
    float nextFire = 0f;

    void Start () {
        playerController.current = this;
        myRB = GetComponent<Rigidbody2D>();
        myAnim = GetComponent<Animator>();
        facingRight = true;
    }

    void Update()
    {
        if(grounded && CrossPlatformInputManager.GetButton("Jump"))
        {
            grounded = false;
            myAnim.SetBool("IsGrounded", false);
            myRB.AddForce(new Vector2(0, jumpHeight));
        }

        if (CrossPlatformInputManager.GetButton("Fire1") && cont.ContadorMunicio >0) fireRocket();
        //this.UpdateAmountText();

    }

    void FixedUpdate () {

        grounded = Physics2D.OverlapCircle(groundCheck.position,groundCheckRadius,groundLayer);
        myAnim.SetBool("IsGrounded", grounded);
        myAnim.SetFloat("verticalSpeed", myRB.velocity.y);


        float move = CrossPlatformInputManager.GetAxis("Horizontal");
        myAnim.SetFloat("Speed", Mathf.Abs(move));
        myRB.velocity = new Vector2(move * maxSpeed, myRB.velocity.y);

        if(move>0&&!facingRight)
        {
            flip();
        }
        else if (move < 0 && facingRight)
        {
            flip();
        }
	}


    void flip()
    {

        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }

    void fireRocket()
    {
        if (Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            if (facingRight)
            {
                Instantiate(bullet, gunTip.position, Quaternion.Euler(new Vector3(0, 0, 0)));
               this.cont.ContadorMunicio--;
            }
            else if (!facingRight)
            {
                Instantiate(bullet, gunTip.position, Quaternion.Euler(new Vector3(0, 0, 180f)));
                this.cont.ContadorMunicio--;
            }
        }
    }

}
