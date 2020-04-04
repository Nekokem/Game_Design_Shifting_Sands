using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamageTrigger : MonoBehaviour
{
    public int playerAttackDamage;

    public void OnTriggerEnter(Collider other)
    {
       
        if (other.GetComponent<EnemyHealth>())
        {
            other.GetComponent<EnemyHealth>().MinusHealth(playerAttackDamage);
        }
    }
}