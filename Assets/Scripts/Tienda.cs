using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Tienda : MonoBehaviour {

    public GameObject MenuCompra;

     void Start()
    {
        this.MenuCompra.SetActive(false);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        this.MenuCompra.SetActive(true);
    }

    void OnTriggerExit2D(Collider2D other)
    {
        this.MenuCompra.SetActive(false);
    }

}
