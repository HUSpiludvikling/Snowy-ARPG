using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PlayerStatsVictor : CharacterStats {

    #region singleton
    public static PlayerStatsVictor instance;

    private void Awake()
    {
        instance = this;
    }

    #endregion

    public float startingHealth = 100;                              // The amount of health the player starts the game with.
    private float currentHealthField;
    public float currentHealth
    {
        get { return currentHealthField; }
        set
        {
            if (value > maxhealth)
            {
                currentHealthField = maxhealth;
            }
            else
            {
                currentHealthField = value;
            }
            SetCurrentHealth(currentHealthField);
        }
    }
    public float maxhealth { get { return startingHealth; } }     // The current health the player has.
    public Image damageImage;                                     // Reference to an image to flash on the screen on being hurt.
    public string SceneLoader;                                    // Loades the scene specified in unity.
    public Text HealthCounter;



    /*public Text HealthStats;
    public Text HealthBar;
    public Text ArmorStats;
    public Text DamageStats;
    */
    private void SetCurrentHealth(float currentHp)
    {
        //Debug.Log((currentHealth / startingHealth).ToString("0.0"));
        //healthSlider.value = currentHealth;
        damageImage.fillAmount = (currentHealth / startingHealth);
        if (currentHp <= 0)
        {
            SceneManager.LoadScene(SceneLoader);
        }
        HealthCounter.text = currentHp.ToString();

    }

    

    //public Text HealthStats;
    //public Text HealthBar;
    //public Text ArmorStats;
    //public Text DamageStats;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(damage.GetValue());
        }
    }

    public void ChangeEquipment(Equipment newItem)
    {
		if (newItem != null)
		{
				armor.AddModifier(newItem.Armor);
				damage.AddModifier(newItem.Attack);
		}
	}

    public void RemoveEquipment(Equipment oldItem)
    {
        if (oldItem != null)
        {
            armor.RemoveModifier(oldItem.ModifierIndex);
            damage.RemoveModifier(oldItem.ModifierIndex);
        }
    }

    public int GetModifierAmount ()
    {
        if (armor.GetModifierAmount() != damage.GetModifierAmount())
        {
            throw new System.Exception("lengths of modifiers differ");

        }
        return armor.GetModifierAmount();
    }

    public void TakeDamage(int damage)
    {
        damage -= armor.GetValue();
        damage = Mathf.Clamp(damage, minDamage, maxHealth.GetValue());
        currentHealth = currentHealth - damage;
        Debug.Log(transform.name + " tager " + damage + " damage.");

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    private void Start()
    {
        // Set the initial health of the player.
        currentHealth = startingHealth;
        print(currentHealth + " " + startingHealth);
        //SetCurrentHealth(10);
    }
}
