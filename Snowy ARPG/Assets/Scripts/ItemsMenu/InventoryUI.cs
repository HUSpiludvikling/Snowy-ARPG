using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    #region Singleton
    public static InventoryUI instance;

    void Awake()
    {
        instance = this;
    }
    #endregion

    Inventory inventory;

    public Transform itemsParent;
    public GameObject inventoryUI;

    InventorySlot[] slots;

    void Start()
    {
        //snakker til mit inventory
        inventory = Inventory.instance;

        //hver gang der sker noget med det der inventory bliver UpdateUI kaldt.
        inventory.onItemChangedCallback += UpdateUI;

        slots = itemsParent.GetComponentsInChildren<InventorySlot>();
    }


    public void UpdateUI()
    {
        for (int i = 0; i < slots.Length; i++)
        {
            if (i < inventory.items.Count)
            {
                slots[i].AddItem(inventory.items[i]);
            }
            else
            {
                slots[i].ClearItem();
            }
        }
    }

    public void CloseOpenInventory()
    {
        inventoryUI.SetActive(!inventoryUI.activeSelf);
    }
    private void Update()
    {
        if (Input.GetButtonDown("Inventory"))
            inventoryUI.SetActive(!inventoryUI.activeSelf);
    }
}
