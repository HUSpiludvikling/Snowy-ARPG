using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour {

    //Player stats at level 1
    public float Power = 1f;
    public float Endurances = 10f;

    //the Damage scaler (Attack * Power)
    public float Attack = 1f;

    //the health scaler (HP * Endurances)
    public float HP = 10f;

    //Vægler hvilken scene der skal skiftes til hvis man dør.
    public string SceneLoader = "";

    //Amount of points to spend on stuff like "Power and Endurances"
    public float StatPoints = 5f;

    //Calls code within the brakes each frame.
    private void Update()
    {
        //Calc how much damage you can take, before dying/lossing.
        float Health = Endurances * HP;

        //Calc how much damage you can deal in a singel hit.
        float Damage = Power * Attack;

        string DamageNumbers = "Damage " + Damage;
        
        //loades the "loosing" scene.
        if(Health <= 0f)
        {
            SceneManager.LoadScene (SceneLoader);
        }






    }





}
