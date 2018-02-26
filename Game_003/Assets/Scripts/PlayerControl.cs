using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerMotor))]


public class PlayerControl : MonoBehaviour {

    public LayerMask movementMask;
    public Interactable focus;

    Camera cam;
    PlayerMotor motor;
    
	void Start () {
        cam = Camera.main;
        motor = GetComponent<PlayerMotor>(); 
	}
	
    //Når man venstreklikker
	void Update () {
		if (Input.GetMouseButtonDown(0))
        {
            //får man en ray
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            //og hvis den ray rammer noget
            if (Physics.Raycast(ray, out hit, 100, movementMask))
            {
                //så flytter spilleren til hvad vi ramte.
                motor.MoveToPoint(hit.point);

                //Stopper med at fokusere et objekt
                RemoveFocus();

            }
        }

        //når man højreklikkerz
        if (Input.GetMouseButtonDown(1))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;


            // Hvis ray rammer
            if (Physics.Raycast(ray, out hit, 100, movementMask))
            {
            
                Interactable interactable = hit.collider.GetComponent<Interactable>();
                if (interactable != null)
                {
                    SetFocus(interactable);
                }

            }
        }
    }
    void SetFocus (Interactable newFocus)
    {
        focus = newFocus;
        motor.FollowTarget(newFocus);
    }
    void RemoveFocus()
    {
        focus = null;
        motor.StopFollowingTarget();
    }
}
