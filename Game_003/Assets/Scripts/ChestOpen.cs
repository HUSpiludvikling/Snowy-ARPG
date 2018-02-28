using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestOpen : MonoBehaviour {
    private Animator ChestAnim;
    private bool inside = false;

    public Transform ChestPosition;
    public PlayerMotor PM;

    private void Start()
    {
        PM = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMotor>();
    }

    private void OnMouseDown()
    {
        PM.ReceiveRemotePosition(ChestPosition.position);
        Debug.Log("dewifjew");
    }

















    /*private void Start()
    {
        ChestAnim = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            inside = true;   
        }
    }

    private void OnMouseDown()
    {

        Debug.Log("den virker");

    if (inside == true)
    {

    ChestAnim.SetBool("close", false);
    ChestAnim.SetBool("open", true);
    }''

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            ChestAnim.SetBool("open", false);
            ChestAnim.SetBool("close", true);
            inside = false;
        }
    }*/

}
