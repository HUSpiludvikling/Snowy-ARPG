using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Inventory : MonoBehaviour
{
    #region Singleton
    public static Inventory instance;
    
    void Awake ()
    {
        instance = this;
    }
	#endregion

	public UnityEvent eksempel;
    public delegate void OnItemChanged();
    public OnItemChanged onItemChangedCallback;

    //det her er listen
    public List<Item> items = new List<Item>();

    //det her er hvor mange items der må være i listen
    public int inventorySlots = 25;

    //tilføjer item til listen
    public bool Collect (Item item)
    {
        //hvis item er default så sker intet
        if (!item.IsDefaultItem)
        {
            //hvis der er flere items end slots så kan man ikke.
            if (items.Count >= inventorySlots)
            {
                Debug.Log("No more sluts");
                return false;
            }
            //Det er meningen at den her skal tilføje en item. yay
            items.Add(item);
            if (onItemChangedCallback != null)
            onItemChangedCallback.Invoke();
        }

        return true;
    }

    //fjerner item fra listen
    public void Remove (Item item)
    {
        items.Remove(item);
        if (onItemChangedCallback != null)
            onItemChangedCallback.Invoke();
    }
}
