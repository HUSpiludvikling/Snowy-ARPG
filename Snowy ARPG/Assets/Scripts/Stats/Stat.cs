using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Stat {
    
    [SerializeField]
    private int baseValue;



    public int GetValue ()
    {
        int finalValue = baseValue;
        modifiers.ForEach(x => finalValue += x);
        return finalValue;
    }

    private List<int> modifiers = new List<int>();

    public void AddModifier ( int modifier )
    {

            modifiers.Add(modifier);
    }
    public void RemoveModifier ( int index )
    {
            modifiers.RemoveAt(index);
    }

    public int GetModifierAmount ()
    {
        return modifiers.Count;
    }
}
