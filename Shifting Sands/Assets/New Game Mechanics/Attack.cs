using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public GameObject hitbox;
    public float Timer;
    public bool AttackingIsRunning = false;
    public int AttackingHealth;

    void Update()
    {
        //get input
        if(Input.GetMouseButtonDown(0))
        {
            if(AttackingIsRunning == false){
                GetComponent<Health>().SubtractHealth(AttackingHealth);
                StartCoroutine(Attacking());
            }
        }      
    }

    IEnumerator Attacking()
    {
        AttackingIsRunning = true;

        //turn on hitbox
        hitbox.SetActive(true);
        
        //Set timer
        yield return new WaitForSeconds(Timer); 

        //turn off hitbox
        hitbox.SetActive(false);

        AttackingIsRunning = false;
    }
}