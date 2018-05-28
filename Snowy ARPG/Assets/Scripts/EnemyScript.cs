using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {

    public int health = 100;
    public int playerDamage = 15;
    public int speed = 1;
    public GameObject enemy;
    public bool active = true;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Projectile"))
        {
            Debug.Log("HHAHE");
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag.Equals("Player"))
        {
            if (Input.GetKey(KeyCode.Alpha1) && (active = true))
            {
                StartCoroutine(EnemyDamaged());
                Debug.Log("being dyed");
                active = false;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag.Equals("Player"))
        {
            StopCoroutine(EnemyDamaged());
        }
    }
    IEnumerator EnemyDamaged()
    {
        health = health - playerDamage;
        if (health <= 0)
        {
            enemy.SetActive(false);
        }
        yield return new WaitForSeconds(speed);
        active = true;
    }
}
