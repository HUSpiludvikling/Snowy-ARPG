using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AggroTrigger : MonoBehaviour {

    PlayerStatsVictor psvref;

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
            psvref.TakeDamage(5);
            yield return new WaitForSeconds(1);

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
