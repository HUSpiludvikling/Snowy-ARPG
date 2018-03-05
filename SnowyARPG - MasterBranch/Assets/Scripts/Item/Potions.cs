using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="New Potion", menuName ="Item/Potion")]
public class Potions : Item {

    public int Amount;
    public PotionTypes potionTypes;
}
public enum PotionTypes
{
HealthPotion,
ManaPotion
}