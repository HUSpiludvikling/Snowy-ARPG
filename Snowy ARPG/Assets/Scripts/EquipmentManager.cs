using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipmentManager : MonoBehaviour
{
    #region Singleton
    public PlayerViewSlot[] slots;
    public static EquipmentManager instance;

    void Awake()
    {
        instance = this;
    }
    #endregion

    public Equipment[] currentEquipment;

    void Start()
    {
        int numSlots = System.Enum.GetNames(typeof(EquipmentSlots)).Length;
        currentEquipment = new Equipment[numSlots];

        var objs = GameObject.FindGameObjectsWithTag("EquipmentSlot");
        slots = new PlayerViewSlot[objs.Length];
        for (int i = 0; i < objs.Length; i++)
            slots[i] = objs[i].GetComponent<PlayerViewSlot>();

    }

    public void Equip(Equipment newItem)
    {
        int slotIndex = (int)newItem.equipmentSlot;

        currentEquipment[slotIndex] = newItem;
        Debug.Log("EquipmentManager");

        slots[slotIndex].Equip(newItem);
    }
}
