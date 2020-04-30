using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    public FloatData healthCollection;
    public FloatData damageHealth;
    public FloatData attackDamage;
    public UnityEvent TakeDamageEvent;
    public UnityEvent DieEvent;

    private void Start()
    {
        healthCollection.value = healthCollection.value;
    }

    public void SubtractHealth(FloatData attackDamage)
    {
        healthCollection.value -= damageHealth.value;
        TakeDamageEvent.Invoke();

        if (healthCollection.value <= 0)
        {
            Died();
        }
    }

    public void GainHealth()
    {
        healthCollection.value += 20;
    }

    public void Died()
    {
        DieEvent.Invoke();
    }
}