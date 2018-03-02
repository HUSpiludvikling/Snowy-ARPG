using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

    public enum itemType // your custom enumeration
{
    Daggert,
    Sword,
    Mace
}

[CreateAssetMenu(fileName = "Item", menuName = "Item")]
public class Item : ScriptableObject {

    public new string name;
    public string description;
    public bool IsDefaultItem = false;
    public Sprite picture;
    public itemType Dropdown;


    public int attackDamage = 0;
    public float attackRadius;
    public float attackSpeed;

}   
