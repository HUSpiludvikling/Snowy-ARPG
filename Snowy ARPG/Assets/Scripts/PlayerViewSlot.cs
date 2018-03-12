using UnityEngine;
using UnityEngine.UI;

public class PlayerViewSlot : MonoBehaviour
{

    public Image icon;
    public Button removeButton;
    public Item Item;


    public void AddEquipment(Equipment quip)
    {
        icon.sprite = quip.icon;
        Item = quip;
        icon.enabled = true;
    }
    public void Remove()
    {
        Inventory.instance.Collect(Item);
        Item = null;
        icon.sprite = null;
        icon.enabled = false;
    }
    public void CloseButton()
    {
        Inventory.instance.Remove(Item);
    }
}