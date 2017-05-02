using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {

    public float fullHealth;
    public GameObject deathFX;
    public AudioClip playerHurt;
    float currentHealth;
    public ReiniciarJuego GameManager;

    playerController controlMovement;
    AudioSource playerAS;

    public Slider healthSlider;
    public Image damageScreen;
    public Text gameOverScreen;
    public Text WinningGameScreen;
    bool damaged;
    Color damagedColour = new Color(150f, 0f, 0f, 0.5f);
    float smoothColour = 5f;


	void Start () {
        currentHealth = fullHealth;
        controlMovement = GetComponent<playerController>();

        healthSlider.maxValue = fullHealth;
        healthSlider.value = fullHealth;

        damaged = false;

        playerAS = GetComponent<AudioSource>();
    }
	
	void Update () {

        if (damaged)
        {
            damageScreen.color = damagedColour;
        }
        else
        {
            damageScreen.color = Color.Lerp(damageScreen.color, Color.clear, smoothColour * Time.deltaTime);
        }
        damaged = false;
	}


    public void addDamage(float damage)
    {
        if (damage <= 0) return;
        currentHealth -= damage;
        playerAS.clip = playerHurt;
        playerAS.Play();
  //      playerAS.PlayOneShot(playerHurt);
        healthSlider.value = currentHealth;
        damaged = true;

        if (currentHealth <= 0)
        {
            makeDead();
        }
    }



    public void addHealth(float health)
    {
        currentHealth += health;
        if (currentHealth > fullHealth) currentHealth = fullHealth;
        healthSlider.value = currentHealth;
    }

    public void makeDead()
    {
        Instantiate(deathFX, transform.position, transform.rotation);
        Destroy(gameObject);
        damageScreen.color = damagedColour;
        Animator gameOverAnimator = gameOverScreen.GetComponent<Animator>();
        gameOverAnimator.SetTrigger("GameOver");
        GameManager.RestartGame();
    }

    public void winGame()
    {
        Destroy(gameObject);
        GameManager.RestartGame();
        Animator winGameAnimator = WinningGameScreen.GetComponent<Animator>();
        winGameAnimator.SetTrigger("GameOver");
    }
}
