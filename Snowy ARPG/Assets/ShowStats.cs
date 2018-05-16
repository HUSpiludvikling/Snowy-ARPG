using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowStats : MonoBehaviour {

    public Text currentHP;
    public Text maxHP;
    public Text damage;
    public Text armor;

    public PlayerStatsVictor PS;



    void Start () {
        maxHP.text = PS.startingHealth.ToString();
        currentHP.text = PS.startingHealth.ToString();
        armor.text = PS.armor.ToString();
        damage.text = PS.damage.ToString();
	}
	
	
	void Update () {
        maxHP.text = PS.startingHealth.ToString();
        currentHP.text = PS.startingHealth.ToString();
        armor.text = PS.armor.ToString();
        damage.text = PS.damage.ToString();
    }
}
