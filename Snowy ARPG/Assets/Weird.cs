using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weird : MonoBehaviour {
    
    public GameObject glass;
    public GameObject helmet;
    public float hPgained;
    public float aTKgained;
    public EnemyScript eS;
    

    private void OnMouseDown()
    {
        if (glass != null)
        {
            glass.SetActive(true);
            helmet.SetActive(true);
        }
        if (hPgained != 0)
        {

        }
        if (aTKgained != 0)
        {
            //
        }
    }
}
