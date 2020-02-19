using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Interactable focus;
    private Camera cam;
    public Animator anim;
   
    void Start()
    {
        cam = Camera.main;
        anim = gameObject.GetComponent<Animator>();
    }
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            
            anim.SetTrigger("Active");

            if (Physics.Raycast(ray, out hit, 100))
            {
                Interactable interactable = hit.collider.GetComponent<Interactable>();

                if (interactable != null)
                {
                    //write function for what to do here when you click
                    //Debug.Log("the player is interacting");
                    SetFocus(interactable);
                }
            }
        }

        if (Input.GetMouseButtonUp(0))
        {
            anim.SetTrigger("notActive");
        }
    }

    void SetFocus(Interactable newFocus)
    {
        if (newFocus != focus)
        {
            if (focus != null)
                focus.OnDefocused();
            focus = newFocus;
        }
        newFocus.OnFocused(transform);
    }

    void RemoveFocus()
    {
        if (focus != null)
            focus.OnDefocused();
        
        focus = null;
    }
}