using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    public int healthCollection = 100;
    public UnityEvent TakeDamageEvent;
    public UnityEvent DieEvent;

    public void SubtractHealth(int attackDamage)
    {
        healthCollection -= 10;
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
