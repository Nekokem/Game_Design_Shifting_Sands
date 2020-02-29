using UnityEngine;

public class Interactable : MonoBehaviour
{
    public float radius = 5f; //range of interaction

    //public Color clickedColor;
    // public Color restingColor;

    private bool isFocus = false;
    
    private Transform player;

    private bool hasInteracted = false;
    private bool clicked = false;

    public Color clickedColor;
    public virtual void Interact()
    {
        //this method is meant to change depending on who it's used on
        //Debug.Log("interacting with" + transform.name);
    }
    private void Update()
    {
        
        if (isFocus && !hasInteracted)
        {
            float distance = Vector3.Distance(player.position, transform.position);
            if (distance <= radius)
            {
                
                Interact();
                //Debug.Log("I am interacting");
                hasInteracted = true;
                OnMouseDown();
            }
        }
    }

    public void OnMouseDown()
    {
        gameObject.GetComponent<Renderer>().material.color = clickedColor;
        //Debug.Log("I am clicked");
    }

    public void OnFocused(Transform playerTransform)
    {
        isFocus = true;
        player = playerTransform;
        hasInteracted = false;
    }
    
    public void OnDefocused()
    {
        isFocus = false;
        player = null;
        hasInteracted = false;
    }
    
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position, radius);
    }
}