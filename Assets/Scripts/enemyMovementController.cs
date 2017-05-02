using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMovementController : MonoBehaviour {

    public float enemySpeed;
    Animator enemyAnimator;

    public GameObject enemyGrapher;
    bool CanFlip = true;
    bool FacingRight = false;
    float FlipTime = 5f;
    float nextFlipChance = 0f;

    public float chargeTime;
    float startChargeTime;
    bool charging;
    Rigidbody2D enemyRB;

	void Start () {
        enemyAnimator = GetComponentInChildren<Animator>();
        enemyRB = GetComponent<Rigidbody2D>();
	}
	

	void Update () {
		if(Time.time > nextFlipChance)
        {
            if (Random.Range(0, 10) >= 5) flipFacing();
            nextFlipChance = Time.time + FlipTime;
        }
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            if (FacingRight && other.transform.position.x < transform.position.x)
            {
                flipFacing();
            }
            else if (!FacingRight && other.transform.position.x > transform.position.x)
            {
                flipFacing();
            }
            CanFlip = false;
            charging = true;
            startChargeTime = Time.time + chargeTime;
        }
    }


     void OnTriggerStay2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            if (startChargeTime < Time.time)
            {
                if (!FacingRight) enemyRB.AddForce(new Vector2(-1, 0) * enemySpeed);
                else enemyRB.AddForce(new Vector2(1, 0) * enemySpeed);
                enemyAnimator.SetBool("IsCharging", charging);
            }
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            CanFlip = true;
            charging = false;
            enemyRB.velocity = new Vector2(0f, 0f);
            enemyAnimator.SetBool("IsCharging", charging);
        }
    }

    void flipFacing()
    {
        if (!CanFlip) return;
        float facingX = enemyGrapher.transform.localScale.x;
        facingX *= -1f;
        enemyGrapher.transform.localScale = new Vector3(facingX, enemyGrapher.transform.localScale.y, enemyGrapher.transform.localScale.z);
        FacingRight = !FacingRight;

    }
}
