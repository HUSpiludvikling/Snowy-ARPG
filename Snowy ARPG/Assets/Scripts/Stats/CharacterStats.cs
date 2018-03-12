using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStats : MonoBehaviour {
    
    public Stat maxHealth;
    public int currentHealth;
    public Stat armor;
    public Stat damage;
    public int minDamage;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(damage.GetValue());
        }
    }

    private void Awake()
    {
        currentHealth = maxHealth.GetValue();
    }
    public void TakeDamage(int damage)
    {
        damage -= armor.GetValue();
        damage = Mathf.Clamp(damage, minDamage, maxHealth.GetValue());

        currentHealth = currentHealth - damage;
        Debug.Log(transform.name + " tager " + damage + " damage.");

        if(currentHealth <= 0)
        {
            Die();
        }
    }

    public virtual void Die ()
    {
        Debug.Log(transform.name + " er død.");
    }
}
