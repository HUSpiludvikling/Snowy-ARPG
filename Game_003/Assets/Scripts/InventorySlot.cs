using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySlot : MonoBehaviour {

    public Item item;

    public void CollectItem ()
    {
        Debug.Log("You picked " + item.name + " up");
    }
	
}
