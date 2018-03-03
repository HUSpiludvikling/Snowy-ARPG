using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavBar : MonoBehaviour {

    public Animator NavAnimator;
    public GameObject NavigationBar;
    bool NavBarOpen=false;
    

    private void Start()
    {
        NavAnimator.Play("NavBarIdle");
    }

    public void NavBarOpenClose ()
    {
        if (NavBarOpen == false)
        {
            NavAnimator.Play("NavBarClosed");
            NavBarOpen = true;
            NavigationBar.SetActive(false);
        }
        else
        {
            NavAnimator.Play("NavBarOpened");
            NavBarOpen = false;
            NavigationBar.SetActive(true);
        }
    }
}
