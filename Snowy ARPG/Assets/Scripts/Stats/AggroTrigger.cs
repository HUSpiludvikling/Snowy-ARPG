using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AggroTrigger : MonoBehaviour {

    PlayerStatsVictor psvref;
    public int attackSpeed;
    public int damage;

    private void Awake()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Player")
        {
            psvref = other.GetComponent<PlayerStatsVictor>();
            StartCoroutine(ContinuedDamage());
        }
    }

    private IEnumerator ContinuedDamage()
    {
        while (psvref != null)
        {
            psvref.TakeDamage(damage);
            yield return new WaitForSeconds(attackSpeed);

        }
        
        
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.transform.tag == "Player")
        {
            psvref = null;
        }
    }


}
