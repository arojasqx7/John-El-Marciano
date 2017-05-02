using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanzaEspora : MonoBehaviour {

    public GameObject theProjectile;
    public float shootTime;
    public int chanceShoot;
    public Transform shootFrom;

    float nextShootTime;
    Animator cannonAnim;

	void Start () {
        cannonAnim = GetComponentInChildren<Animator>();
        nextShootTime = 0f;

    }
	

	void Update () {
		
	}

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Player" && nextShootTime < Time.time) {
            nextShootTime = Time.time + shootTime;
            if(Random.Range(0,10) >= chanceShoot)
            {
                Instantiate(theProjectile,shootFrom.position,Quaternion.identity);
                cannonAnim.SetTrigger("PlantaShoot");
            }
        }
    }
}
