using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

    private PlayerMotor playerMotor;
    private Transform playerPosition;

	void Start () {
        playerMotor = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMotor>();
        playerPosition = playerMotor.transform;
    }

    private void OnMouseDown()
    {
        //MoveToPoint(this.transform);
    }
}
