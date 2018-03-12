using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipmentManager : MonoBehaviour
{
    #region Singleton
    public static EquipmentManager instance;

    void Awake()
    {
        instance = this;
    }
    #endregion

    public delegate void OnEquipmentChanged();
    public OnEquipmentChanged onEquipmentChangedCallback;

    public Equipment[] currentEquipment;

    Inventory inventory;

    void Start()
    {
        int numSlots = System.Enum.GetNames(typeof(EquipmentSlots)).Length;
        currentEquipment = new Equipment[numSlots];

        inventory = Inventory.instance;

        /*var objs = GameObject.FindGameObjectsWithTag("EquipmentSlot");
        slots = new PlayerViewSlot[objs.Length];
        for (int i = 0; i < objs.Length; i++)
            slots[i] = objs[i].GetComponent<PlayerViewSlot>();*/

    }

    public void Equip(Equipment newItem)
    {
        int slotIndex = (int)newItem.equipmentSlot;

        Equipment oldItem = null;

        if (currentEquipment[slotIndex] != null)
        {
            oldItem = currentEquipment[slotIndex];
            inventory.Collect(oldItem); //	- This caused duplication bug.

            PlayerViewUI.instance.UpdateUI();
        }

        currentEquipment[slotIndex] = newItem;
        PlayerStatsVictor.instance.ChangeEquipment(newItem, oldItem);

    }

    public void Unequip(int slotIndex)
    {
        if(currentEquipment[slotIndex] != null)
        {
            Equipment oldItem = currentEquipment[slotIndex];
            inventory.Collect(oldItem);


            currentEquipment = null;

            PlayerViewUI.instance.UpdateUI();
        }
    }
    
    public void UnequipAll()
    {
        for (int i = 0; i < currentEquipment.Length; i++)
        {
            Unequip(i);
            PlayerViewUI.instance.UpdateUI();
        }
    }

    private void Update()
    {
		if (Input.GetButtonDown("UnequipAll"))
		{
            UnequipAll();
            PlayerViewUI.instance.UpdateUI();
		}
		if(Input.GetKeyDown(KeyCode.K))
		{
			foreach (Equipment item in currentEquipment)
			{
				print(item.description);
			}
		}
    }
}
