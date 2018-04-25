using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu2 : MonoBehaviour {

    public KeyCode pauseKey = KeyCode.Escape;
    public GameObject pauseOverlay;


    private bool paused = false;

    void Start()
    {
       //pauseOverlay.SetActive(false);

    }

    void Update()
    {
        PauseHandler();
        if (Input.GetKeyDown(pauseKey))
            paused = !paused;
    }

    private void PauseHandler()
    {
            if (!paused)
            {
                Time.timeScale = 1.0f;

                pauseOverlay.SetActive(value: paused);
                //print("Unpaused");
            }
            else
            {
                Time.timeScale = 0.0f;
                pauseOverlay.SetActive(paused);

                //print("Paused");
            }
        
    }
}
