using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activatorr : MonoBehaviour {

    public GameObject VideoEditor;
    public GameObject Canvas;

    private void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0) || Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.Escape))
        {
            Canvas.SetActive(true);
            VideoEditor.SetActive(false);
        }
    }
}
