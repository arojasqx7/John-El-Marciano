using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow2 : MonoBehaviour {

    public Transform personaje;
    public float separation = 5f;


    //   void Start () {

    //}


    void Update()
    {
        transform.position = new Vector3(personaje.position.x + separation, transform.position.y, transform.position.z);
    }



}
