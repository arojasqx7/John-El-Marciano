using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SporaController : MonoBehaviour {

    public float SporeSpeedHigh;
    public float sporeSpeedLow;
    public float sporeAngle;
    public float sporeTorqueAngle;

    Rigidbody2D sporeRB;

	void Start () {
        sporeRB = GetComponent<Rigidbody2D>();
        sporeRB.AddForce(new Vector2(Random.Range(-sporeAngle, sporeAngle),Random.Range(sporeSpeedLow,SporeSpeedHigh)),ForceMode2D.Impulse);
        sporeRB.AddTorque((Random.Range(-sporeTorqueAngle, sporeTorqueAngle)));

    }
	

	void Update () {
		
	}
}
