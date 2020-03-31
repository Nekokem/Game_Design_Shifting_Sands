using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageTrigger : MonoBehaviour
{
    public int AttackDamage;

    public void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Health>())
        {
            other.GetComponent<Health>().SubtractHealth(AttackDamage);
        }
    }
}
