using UnityEngine;

public class InteractableV2 : MonoBehaviour {

    public float radius = 3f;
    public Transform interactionTransform;

    bool isFocus = false;
    Transform Player;

    public virtual void Interact()
    {
        Debug.Log("Interacting with " + transform.name);
    }

    bool HasInteracted = false;

    private void Update()
    {
        if (isFocus && !HasInteracted)
        {
            float distance = Vector3.Distance(Player.position, interactionTransform.position);
            if (distance <= radius)
            {
                Debug.Log("Interact");
                HasInteracted = true;
            }
        }
    }

    public void OnFocused (Transform PlayersTransform)
    {
        isFocus = true;
        Player = PlayersTransform;
        HasInteracted = false;
    }

    public void OnDefocused()
    {
        isFocus = false;
        Player = null;
        HasInteracted = false;
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(interactionTransform.position, radius);
    }


}
