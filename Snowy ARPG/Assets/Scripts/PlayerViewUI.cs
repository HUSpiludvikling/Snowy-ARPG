using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerViewUI : MonoBehaviour {

    #region Singleton
    public static PlayerViewUI instance;

    void Awake()
    {
        instance = this;
    }
    #endregion

    EquipmentManager equipmentManager;
    
    PlayerViewSlot[] slots;
    public Transform itemsParent;

    public void Start()
    {
        equipmentManager = EquipmentManager.instance;
        
        equipmentManager.onEquipmentChangedCallback += UpdateUI;

        slots = itemsParent.GetComponentsInChildren<PlayerViewSlot>();

        /*var objs = GameObject.FindGameObjectsWithTag("EquipmentSlot");
        slots = new PlayerViewSlot[objs.Length];
        for (int i = 0; i < objs.Length; i++)
            slots[i] = objs[i].GetComponent<PlayerViewSlot>();*/
        
    }

    public void UpdateUI()
    {
        Debug.Log("UI Updated");
        for (int i = 0; i < slots.Length; i++)
        {
            if (i < equipmentManager.currentEquipment.Length)
            {
                slots[i].AddEquipment(equipmentManager.currentEquipment[i]);
            }
            else
            {
                slots[i].Remove();
            }
        }
    }
}
