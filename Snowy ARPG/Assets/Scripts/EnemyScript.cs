using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {

    public int health;

	void Start () {
        //GameObject.GameReference;
	}

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Projectile"))
        {
            Debug.Log("HHAHE");
        }
    }

 }
