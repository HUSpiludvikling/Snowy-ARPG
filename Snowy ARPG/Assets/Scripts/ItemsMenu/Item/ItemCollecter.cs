/*
 Det her script kan du sætte på et GameObject der skal samles op.
 For eksempel kan du sætte den på et slot i en kiste og så
 kan du få det slot til at trigger CollectItem med en button.
 
 Hvis du vil trigger det på andre måder end med en button
 så må du lave scriptet til det :)))
 */

using UnityEngine;
using UnityEngine.UI;

public class ItemCollecter : MonoBehaviour {

    //det er her man får den der item fra
    public Item item;

    //det er her du skal putte dit icon ind
    public Image icon;

    //henter icon fra item
    public void Start()
    {
        icon.sprite = item.icon;
    }

    //Det her tilføjer din item til din inventory. :D
    public void CollectItem ()
    {
        Debug.Log("You picked " + item.name + " up");
        //tilføjer item til inventory
        Inventory.instance.Collect(item);
        //fjerner det du har samlet op
            Destroy(gameObject);
    }
	
}
