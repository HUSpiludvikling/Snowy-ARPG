using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatsVictor : CharacterStats {

    #region singleton
    public static PlayerStatsVictor instance;

    private void Awake()
    {
        instance = this;
    }

    #endregion

    public void ChangeEquipment(Equipment newItem, Equipment oldItem)
    {
    if (newItem != null)
        {
            armor.AddModifier(newItem.Armor);
            damage.AddModifier(newItem.Attack);
          } 
    if (oldItem != null)
        {
            armor.RemoveModifier(oldItem.Armor);
            damage.RemoveModifier(oldItem.Attack);
        }
    }


}
