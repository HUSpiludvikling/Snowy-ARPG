using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {

    public int health = 100;
    public int playerDamage;

	void Start () {
        
	}

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Projectile"))
        {
            Debug.Log("HHAHE");
        }
        if (other.tag.Equals("Player"))
        {
            StartCoroutine(EnemyDamaged());
            Debug.Log("being dyed");
        }
        else
        {
            StopCoroutine(EnemyDamaged());
            Debug.Log("not being dyed");
        }

    }
    IEnumerator EnemyDamaged()
    {
        yield return new WaitForSeconds(3);
        health -= playerDamage;
    }
}
