using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

    public enum itemType // your custom enumeration
{
    Weapon,
    Potion,
    Wearable
}

[CreateAssetMenu(fileName = "Item", menuName = "Item")]
public class Item : ScriptableObject {

     [Header("Item Settings")]

    public new string name;
    public string description;
    public itemType Type;
   public int cost = 1;
    public Sprite picture;
    public Sprite icon;
    public Mesh mesh;
    
    public bool IsDefaultItem = false;
    

    [Header("For weapons")]
    public int attackDamage = 0;
    public float attackRadius = 0;
    public float attackSpeed = 0;

    [Header("For potions")]
    public int healthReceived = 0;
    public int manaReceived = 0;

    [Header("For wearables")]
    public int armor = 0;


}   
