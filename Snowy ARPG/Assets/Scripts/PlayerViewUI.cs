using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerViewUI : MonoBehaviour {

    public GameObject playerViewUI;

    public void CloseOpenPlayerView()
    {
        playerViewUI.SetActive(!playerViewUI.activeSelf);
    }
    private void Update()
    {
        if (Input.GetButtonDown("Player View"))
        {
            playerViewUI.SetActive(!playerViewUI.activeSelf);
        }
    }
}
