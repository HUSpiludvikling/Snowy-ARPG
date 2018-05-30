using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {

    public int health = 100;
    public int playerDamage = 15;
    public float cooldownSpeed = 1;
    public GameObject enemy;
    public bool active = true;
    public PlayerMotor pm;
    public Transform target;
    public GameObject PopupText;

    private void Start()
    {
        

        //pm = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMotor>();
    }

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
            if (Input.GetKey(KeyCode.Alpha1) && (active == true))
            {
                active = false;
                pm.RetardedAirPunching();
                StartCoroutine(Waiter());
                health = health - playerDamage;

                ShowPopupText();

                if (health <= 0)
                {
                    enemy.SetActive(false);
                }
            }
        }
    }

    void ShowPopupText ()
    {
        Instantiate(PopupText, transform.position, Quaternion.identity, transform);
    }

    IEnumerator Waiter()
    {
        yield return new WaitForSeconds(cooldownSpeed);
        active = true;
    }
}
