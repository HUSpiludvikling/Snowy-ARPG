using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerMotor))]
public class PlayerControl : MonoBehaviour {
    public LayerMask movementMask;

    Camera cam;
    PlayerMotor motor;
    
	void Start () {
        cam = Camera.main;
        motor = GetComponent<PlayerMotor>(); 
	}
	
	void Update () {
		if (Input.GetMouseButtonDown(1))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100, movementMask))
            {
                //Flytter spiller til hvor der blev klikket
                motor.MoveToPoint(hit.point);

                //Stopper med at fokusere et objekt

            }
        }
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100, movementMask))
            {
                Debug.Log("Hello motherfucking " + hit.collider.name + " " + hit.point);

                    // Check if interactable is hit
                    // If hit set as focus

            }
        }
    }
}
