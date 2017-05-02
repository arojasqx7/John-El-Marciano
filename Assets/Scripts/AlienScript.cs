using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienScript : MonoBehaviour {

    public float ShootInterval = 1f;
    private float shootInterval;
    public GameObject AlienBala;

    void Start () {
        shootInterval = ShootInterval;

    }
	

	void Update () {

        shootInterval -= Time.deltaTime;
        if(shootInterval < 0)
        {
            Shoot();
            shootInterval = ShootInterval;
        }
    }

    void Shoot()
    {
        Instantiate(AlienBala, transform.position,new Quaternion());
    }

}
