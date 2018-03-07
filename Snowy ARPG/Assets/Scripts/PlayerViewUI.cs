using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerViewUI : MonoBehaviour {

    public GameObject playerViewUI;
    public PlayerViewSlot []slots;
   

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
    public void Start()
    {
        var objs = GameObject.FindGameObjectsWithTag("EquipmentSlot");
        slots = new PlayerViewSlot[objs.Length];
        for (int i = 0; i < objs.Length; i++)
            slots[i] = objs[i].GetComponent<PlayerViewSlot>();
        
    }
    public void Equip(Equipment equipment)
    {
        slots[(int)equipment.equipmentSlot].Equip(equipment);
    }
}
