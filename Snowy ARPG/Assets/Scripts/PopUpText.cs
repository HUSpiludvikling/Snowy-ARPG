using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUpText : MonoBehaviour {

    public float destoryTime = 2f;
    public Vector3 offset = new Vector3(0,2,0);

	void Start ()
    {
        DestroyObject(this, destoryTime);
        transform.localPosition += offset;

        
    }
}
