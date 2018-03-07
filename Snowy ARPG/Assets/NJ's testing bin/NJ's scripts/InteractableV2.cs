using UnityEngine;

public class InteractableV3 : MonoBehaviour {

    public float radius = 3f;
    public Transform Transform;

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
            float distance = Vector3.Distance(Player.position, Transform.position);
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
        Gizmos.DrawWireSphere(Transform.position, radius);
    }


}
