using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerMotorV2))]

public class PLayerMovementV2 : MonoBehaviour {

    public Interactable focus;
    public LayerMask movementMask;
    Camera cam;
    PlayerMotorV2 motor;

	// Use this for initialization
	void Start () {
        cam = Camera.main;
        motor = GetComponent<PlayerMotorV2>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit, 100, movementMask))
            {
                //Flytter spiller til hvad vi rammer
                //Debug.Log("Hit " + hit.collider.name + " " + hit.point);
                motor.MoveToPoint(hit.point);


                RemoveFocus();
                //Stoper med at fokusere objecter.
            }
        }
        if (Input.GetMouseButtonDown(1))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100))
            {
                //Checker hvis du rammer er intteractable, hvis vi gør set det i fokus
                Interactable interactable = hit.collider.GetComponent<Interactable>();
                if(interactable != null)
                {
                    SetFocus(interactable);


                }
                
            }
        }
    }
    void SetFocus (Interactable newFocus)
    {
        if(newFocus != focus)
        {
            //if(focus != null)
            //    focus.OnDefocused();
            focus = newFocus;
            motor.FollowTraget(newFocus);
        }

        focus = newFocus;
        //newFocus.OnFocused(transform);
        motor.FollowTraget(newFocus);
    }
    void RemoveFocus()
    {
        //if (focus != null)
        //    focus.OnDefocused();
        focus = null;
        motor.StopFollowingTraget();
    }



}
