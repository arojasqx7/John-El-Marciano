using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonedaScript : MonoBehaviour {

    public float Dinero = 0;
    public ContadorDinero cont;

    void OnTriggerEnter2D(Collider2D other)
    {
     //   playerController.current.AddCoin();
        cont.Contador += Dinero;
        Destroy(this.gameObject);
    }
}
