using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStats : MonoBehaviour {
    
    public Stat maxHealth;

    public Stat armor;
    public Stat damage;
    public int minDamage;

   

    public virtual void Awake()
    {
        //currentHealth = maxHealth.GetValue();
    }



    public virtual void Die ()
    {
        Debug.Log(transform.name + " er død.");
    }
}
