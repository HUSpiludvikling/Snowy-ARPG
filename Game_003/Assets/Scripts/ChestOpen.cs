using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestOpen : MonoBehaviour {
    private Animator ChestAnim;
    private bool inside = false;

    private void Start()
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
        if (inside == true)
        {
        ChestAnim.SetBool("close", false);
        ChestAnim.SetBool("open", true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            ChestAnim.SetBool("open", false);
            ChestAnim.SetBool("close", true);
            inside = false;
        }
    }

}
