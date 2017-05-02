using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContadorDinero : MonoBehaviour {

    public float Contador = 0;
    public float ContadorMunicio = 0;
    public Text MarcadorMonedas;
    public Text MarcadorMunicion;

    void Start () {
        Comprar();
    }
	
	// Update is called once per frame
	void Update () {
        MarcadorMonedas.text = Contador.ToString();
        MarcadorMunicion.text = ContadorMunicio.ToString();
    }

   public void Comprar()
    {
       
        if (Contador >= 7 )
        {
            ContadorMunicio = ContadorMunicio + 10;
            Contador -= 7;

            MarcadorMonedas.text = Contador.ToString();
            MarcadorMunicion.text = ContadorMunicio.ToString();
        }
    }
}
