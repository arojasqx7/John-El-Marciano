using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cleaner : MonoBehaviour {


	void Start () {
		
	}
	
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            PlayerHealth playerFell = other.GetComponent<PlayerHealth>();
            playerFell.makeDead();
        }
        else
        {
            Destroy(other.gameObject);
        }
    }
}
