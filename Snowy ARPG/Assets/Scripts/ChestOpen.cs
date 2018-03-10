using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChestOpen : MonoBehaviour {
    private Animator ChestAnim;
    private bool inside = false;
   

    public Transform ChestPosition;
    public PlayerMotor PM;
    public GameObject Chest;

    private void Start()
    {
        ChestAnim = GetComponent<Animator>(); 
        PM = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMotor>();

        ChestAnim.SetBool("open", false);
        ChestAnim.SetBool("close", false);
    }

    private void OnMouseDown()
    {
        PM.ReceiveRemotePosition(ChestPosition.position);
        if (inside == true)
        {
            ChestAnim.SetBool("close", false);
            ChestAnim.SetBool("open", true);

            Chest.SetActive(true);
        }
    }

    public void CloseChest()
    {
        ChestAnim.SetBool("open", false);
        ChestAnim.SetBool("close", true);
        if (Chest.gameObject.activeSelf == true)
        {
            Chest.SetActive(false);
        }
    }
    public void OnTriggerExit (Collider other)
    {
        if (other.tag == "Player")
        {
            ChestAnim.SetBool("open", false);
            ChestAnim.SetBool("close", true);
            inside = false;
            if (Chest.gameObject.activeSelf == true)
            {
            Chest.SetActive(false);
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            inside = true;
        }
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
