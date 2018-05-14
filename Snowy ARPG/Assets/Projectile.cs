using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

    private Rigidbody rB;
    public int speed;
    public Vector3 direction;


    void Start()
    {
        
        rB = GetComponent<Rigidbody>();
    }
	public void Update () {
        rB.AddForce(direction * speed);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (!other.tag.Equals("Player"))
        {
            Debug.Log("werk");
            Debug.Log(other.transform.name + other.tag);
            Destroy(this.gameObject);
        }
    }
}
