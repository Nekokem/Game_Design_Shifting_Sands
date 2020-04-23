using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicAttack : MonoBehaviour
{
    public GameObject playerDamageTrigger;
    public spellType spell;
    public GameObject fireBall;
    public GameObject bigFireBall;
    public GameObject waterBall;
    public GameObject bigWaterBall;
    public GameObject firePoint;
    public float Timer;
    public bool AttackingIsRunning = false;
    
    public enum spellType
    {
            WEAKWATER,
            STRONGWATER,
            WEAKFIRE,
            STRONGFIRE,
            CYCLE
    }

    public void Update()
    {
     
        //get input
        if(Input.GetMouseButtonDown(0))
        {
            if(AttackingIsRunning == false){
                StartCoroutine(Attacking());
            }
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            spell++;
            if (spell == spellType.CYCLE)
            {
                spell = 0;
            }
        }
    }

    IEnumerator Attacking()
    {
        AttackingIsRunning = true;

        GameObject objToSpawn = fireBall;

        switch (spell)
        {
            case spellType.WEAKFIRE:
                objToSpawn = fireBall;
                break;
            case spellType.WEAKWATER:
                objToSpawn = waterBall;
                break;
            case spellType.STRONGFIRE:
                objToSpawn = bigFireBall;
                break;
            case spellType.STRONGWATER:
                objToSpawn = bigWaterBall;
                break;
        }

        Instantiate(objToSpawn, firePoint.transform.position, gameObject.transform.rotation);

        //Set timer
        yield return new WaitForSeconds(Timer); 
        
        AttackingIsRunning = false;
    }
}
