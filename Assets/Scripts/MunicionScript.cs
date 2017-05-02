using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MunicionScript : MonoBehaviour {

    public float Municion = 0;
    public ContadorDinero cont;

	void Start () {
        cont.ContadorMunicio += Municion;
    }
}
