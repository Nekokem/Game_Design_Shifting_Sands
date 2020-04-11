using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicAttack : MonoBehaviour
{
    public GameObject playerDamageTrigger;
    //public spellType spell;
    public GameObject fireBall;
    public GameObject firePoint;
    public float Timer;
    public bool AttackingIsRunning = false;
    
    /*public enum spellType
    {
            WEAKFIRE,
            STRONGFIRE,
            WEAKWATER,
            STRONGWATER
    }*/

    public void Update()
    {
     
        //get input
        if(Input.GetMouseButtonDown(0))
        {
            if(AttackingIsRunning == false){
                StartCoroutine(Attacking());
            }
        }      
    }

    IEnumerator Attacking()
    {
        AttackingIsRunning = true;

        Instantiate(fireBall, firePoint.transform.position, gameObject.transform.rotation);

        //Set timer
        yield return new WaitForSeconds(Timer); 
        
        AttackingIsRunning = false;
    }
}
