using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {

    public float startingHealth = 100;                              // The amount of health the player starts the game with.
    private float currentHealthField;
    public float currentHealth { get { return currentHealthField; } set {
            if(value > maxhealth)
            {
                currentHealthField = maxhealth; 
            }
            else
            {
                currentHealthField = value; 
            }
            SetCurrentHealth(currentHealthField);
        }  }
    public float maxhealth { get { return startingHealth; } }     // The current health the player has.
    //public Slider healthSlider;                                 // Reference to the UI's health bar.
    public Image damageImage;                                     // Reference to an image to flash on the screen on being hurt.
    //public AudioClip deathClip;                                 // The audio clip to play when the player dies.
    //public float flashSpeed = 5f;                               // The speed the damageImage will fade at.
    //public Color flashColour = new Color(1f, 0f, 0f, 0.1f);     // The colour the damageImage is set to, to flash.
    public string SceneLoader;
    private Text texhField;




    private void SetCurrentHealth(float currentHp)
    {
        //Debug.Log((currentHealth / startingHealth).ToString("0.0"));
        //healthSlider.value = currentHealth;
        damageImage.fillAmount = (currentHealth / startingHealth);
        if (currentHp <= 0)
        {
            SceneManager.LoadScene(SceneLoader);
        }
        texhField.text = currentHp.ToString();
    }
    

    void Awake()
    {
        // Set the initial health of the player.
        
        texhField = GetComponentInChildren<Text>();
        currentHealth = startingHealth;
        //SetCurrentHealth(10);
    }
}
