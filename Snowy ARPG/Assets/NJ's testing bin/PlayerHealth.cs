using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {

    public float startingHealth = 100f;                            // The amount of health the player starts the game with.
    public float currentHealth;
    public float maxhealth { get { return startingHealth; } }                                       // The current health the player has.
    //public Slider healthSlider;                                 // Reference to the UI's health bar.
    public Image damageImage;                                   // Reference to an image to flash on the screen on being hurt.
    //public AudioClip deathClip;                                 // The audio clip to play when the player dies.
    //public float flashSpeed = 5f;                               // The speed the damageImage will fade at.
    //public Color flashColour = new Color(1f, 0f, 0f, 0.1f);     // The colour the damageImage is set to, to flash.
    public string SceneLoader;

    void Awake()
    {
        // Set the initial health of the player.
        currentHealth = startingHealth;

    }
    void Update()
    {
        Debug.Log((currentHealth / startingHealth).ToString("0.0"));
        //healthSlider.value = currentHealth;
        damageImage.fillAmount = (currentHealth / startingHealth);
        if (currentHealth <= 0)
        {
            SceneManager.LoadScene(SceneLoader);
        }
        else if (currentHealth > maxhealth)
        {
            currentHealth = maxhealth;
        }
        
    }
}
