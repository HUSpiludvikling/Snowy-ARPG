/*
 Det her script kan du sætte på et GameObject der skal samles op.
 For eksempel kan du sætte den på et slot i en kiste og så
 kan du få det slot til at trigger CollectItem med en button.
 
 Hvis du vil trigger det på andre måder end med en button
 så må du lave scriptet til det :)))
 */

using UnityEngine;

public class ItemCollecter : MonoBehaviour {

    //det er her man får den der item fra
    public Item item;

    //Det her tilføjer din item til din inventory. :D
    public void CollectItem ()
    {
        Debug.Log("You picked " + item.name + " up");
        //tilføjer item til inventory
        bool wasPickedUp = Inventory.instance.Collect(item);
        //fjerner det du har samlet op
        if (wasPickedUp)
            Destroy(gameObject);
    }
	
}
