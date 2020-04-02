using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamageTrigger : MonoBehaviour
{
    public int PlayerAttackDamage;

    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("Worked???");
        /*if (other.GetComponent<EnemyHealth>())
        {
            other.GetComponent<EnemyHealth>().MinusHealth(AttackDamage);
        }*/
    }
}