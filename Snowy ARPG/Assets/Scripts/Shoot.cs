using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {
    
    public GameObject projectile;
    public float cooldown = 2;
    private float timestampCooldown = -100;

	void Start () {
		
	}


	void Update () {
        if (Input.GetKey(KeyCode.Alpha2) && Time.timeSinceLevelLoad > timestampCooldown + cooldown)
        {
            timestampCooldown = Time.timeSinceLevelLoad;
            Debug.Log("2");
            GameObject Temp;
            Temp = GameObject.Instantiate(projectile, transform.position, Quaternion.identity);
            Projectile reference = Temp.GetComponent<Projectile>();
            reference.direction = transform.forward;
            reference.transform.rotation = Quaternion.Euler(0, -90 , 0) * transform.rotation;
        }
        
	}
}
