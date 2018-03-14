using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {

    public PlayerMotor playerMotor;
    public Transform playrPosition;

	void Start () {
        playerMotor = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMotor>();
    }

    private void OnMouseDown()
    {
        //MoveToPoint(this.transform);
    }
}
