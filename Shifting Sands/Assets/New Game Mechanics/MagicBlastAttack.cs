using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicBlastAttack : MonoBehaviour
{
    public GameObject damageTrigger;
    public float Timer;
    public bool AttackingIsRunning = false;
    public bool CanAttack;
    public float AttackCycleTimer;

    void OnTriggerEnter()
    {
        StartAttackCycle();
    }

    public void StartAttackCycle()
    {
        if (AttackingIsRunning == false)
        {
            CanAttack = true;
            StartCoroutine(AttackCycle());
        }
    }

    void OnTriggerExit()
    {
        StopAttackingCycle();
    }

    public void StopAttackingCycle()
    {
        CanAttack = false;
    }

    IEnumerator Attacking()
    {
        AttackingIsRunning = true;

        //turn on hitbox
        damageTrigger.GetComponent<Animator>().SetBool("Attack", true);

        //Set timer
        yield return new WaitForSeconds(Timer); 

        //turn off hitbox
        damageTrigger.GetComponent<Animator>().SetBool("Attack", false);

        AttackingIsRunning = false;
    }

    IEnumerator AttackCycle()
    {
        while(CanAttack == true)
        {
            StartCoroutine(Attacking());
            yield return new WaitForSeconds(AttackCycleTimer);
        }
    }
}
