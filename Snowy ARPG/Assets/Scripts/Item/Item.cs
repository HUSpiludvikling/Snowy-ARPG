using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CreateAssetMenu(fileName = "Item", menuName = "Item")]
public class Item : ScriptableObject {

     [Header("Item Settings")]

     //Her under er en masse data
    public new string name;
    public string description;
    public bool IsDefaultItem = false;
    public Sprite icon;

    public virtual void Use()
    {
        Debug.Log("Using" +" "+ name);
    }

}   
