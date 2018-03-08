using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Equipment", menuName = "Item/Equipment")]
public class Equipment : Item {

    public int Armor;
        public int Attack;
    public EquipmentSlots equipmentSlot;

    public override void Use(Equipment omg)
    {
        base.Use(omg);
            EquipmentManager.instance.Equip(this);
    }

}
public enum EquipmentSlots {
Headgear,
    Weapons,
    Shirt,
    Pants
}