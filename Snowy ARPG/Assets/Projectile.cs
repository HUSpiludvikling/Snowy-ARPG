using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

    private Rigidbody rB;
    public GameObject projectile;
    public int speed;
    public Vector3 direction;


    void Start()
    {
        projectile = GetComponent<GameObject>();
        rB = GetComponent<Rigidbody>();
    }
	public void Update () {
        rB.AddForce(Vector3.forward * speed);
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("werk" );
        Destroy(projectile);
    }
}
