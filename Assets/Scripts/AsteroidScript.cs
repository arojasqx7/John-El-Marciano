using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidScript : MonoBehaviour {

    public float MinTorque;
    public float MaxTorque;
    public float MinForce;
    public float MaxForce;

    void Start () {

        float magnitude = Random.Range(MinForce, MaxForce);
        float x = Random.Range(-2f, 1f);
        float y = Random.Range(-2f, 1f);

        GetComponent<Rigidbody2D>().AddForce(magnitude * new Vector2(x, y));

        float torque = Random.Range(MinTorque, MaxTorque);
        GetComponent<Rigidbody2D>().AddTorque(torque);
    }
	
	
	void Update () {
		
	}
}
