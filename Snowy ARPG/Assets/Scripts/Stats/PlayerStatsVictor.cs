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



    public void ChangeEquipment(Equipment newItem)
    {
		if (newItem != null)
		{
				armor.AddModifier(newItem.Armor);
				damage.AddModifier(newItem.Attack);
		}
	}

    public void RemoveEquipment(Equipment oldItem)
    {
        if (oldItem != null)
        {
            armor.RemoveModifier(oldItem.ModifierIndex);
            damage.RemoveModifier(oldItem.ModifierIndex);
        }
    }

    public int GetModifierAmount ()
    {
        if (armor.GetModifierAmount() != damage.GetModifierAmount())
        {
            throw new System.Exception("lengths of modifiers differ");

        }
        return armor.GetModifierAmount();
    }
}
