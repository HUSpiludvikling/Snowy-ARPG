using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[CreateAssetMenu(fileName = "New Equipment", menuName = "Item/Equipment")]
public class Equipment : Item {

    public int Armor;
    public int Attack;
    public EquipmentSlots equipmentSlot;

    public override void Use()
    {
        base.Use();
        EquipmentManager.instance.Equip(this);
        RemoveFromInventory();
    }

}
public enum EquipmentSlots {
    Headgear,
    Shirt,
    Weapons,
    Pants,
    Shoes,
    Back
}