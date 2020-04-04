using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    public int healthCollection = 100;
    public int maxHealth = 100;
    public UnityEvent TakeDamageEvent;
    public UnityEvent DieEvent;

    private void Start()
    {
        healthCollection = maxHealth;
    }

    public void SubtractHealth(int newHealth)
    {
        healthCollection -= newHealth;
        TakeDamageEvent.Invoke();

        if (healthCollection == 0)
        {
            Died();
        }
    }
    
    public void GainHealth()
    {
        healthCollection += 20;
    }

    public void Died()
    {
        DieEvent.Invoke();
    }
}
