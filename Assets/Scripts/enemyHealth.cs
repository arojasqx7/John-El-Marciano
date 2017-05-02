﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemyHealth : MonoBehaviour {

    public float enemyMaxHealth;
    float currentHealth;
    public GameObject enemyDeathFX;
    public Slider enemySlider;
    public bool drops;

    public GameObject theDrop;

	void Start () {
        currentHealth = enemyMaxHealth;
        enemySlider.maxValue = currentHealth;
       enemySlider.value = currentHealth;
    }
	

	void Update () {
		
	}

    public void addDamage(float damage)
    {
        enemySlider.gameObject.SetActive(true);
        currentHealth -= damage;
        enemySlider.value = currentHealth;

        if (currentHealth <= 0) makeDead();
    }

    void makeDead()
    {
        Destroy(gameObject);
        Instantiate(enemyDeathFX, transform.position, transform.rotation);

        if (drops) Instantiate(theDrop, transform.position, transform.rotation);
    }
}
