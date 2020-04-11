using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public GameObject playerDamageTrigger;
    public float Timer;
    public bool AttackingIsRunning = false;

    public void Update()
    {
     
        //get input
        if(Input.GetMouseButtonDown(1))
        {
            if(AttackingIsRunning == false){
                StartCoroutine(Attacking());
            }
        }      
    }

    IEnumerator Attacking()
    {
        AttackingIsRunning = true;

        //turn on hitbox
        playerDamageTrigger.SetActive(true);
        
        //Set timer
        yield return new WaitForSeconds(Timer); 

        //turn off hitbox
        playerDamageTrigger.SetActive(false);

        AttackingIsRunning = false;
    }
}