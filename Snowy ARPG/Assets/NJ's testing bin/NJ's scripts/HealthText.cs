using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthText : MonoBehaviour {

    public Text hpText;

    public PlayerHealth Ph;

    public void Start()
    {
        hpText = GetComponent<Text>();
    }
    private void Update()
    {
        if(Ph.currentHealth != null)
        {
            hpText.text = Ph.currentHealth.ToString();
        }
    }

}
