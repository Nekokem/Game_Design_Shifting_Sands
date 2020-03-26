using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    public int healthCollection = 100;
    public UnityEvent TakeDamageEvent;
    public UnityEvent DieEvent;

    public void CrocodileSubtractHeath()
    {
        healthCollection -= 10;
        TakeDamageEvent.Invoke();

        if (healthCollection == 0)
        {
            Died();
        }
    }

    public void CobraSubtractHealth()
    {
        healthCollection -= 5;
        TakeDamageEvent.Invoke();

        if (healthCollection == 0)
        {
            Died();
        }
    }
    
    public void KingCcbraSubtractHealth()
    {
        healthCollection -= 20;
        TakeDamageEvent.Invoke();

        if (healthCollection == 0)
        {
            Died();
        }
    }
    
    public void MummySubtractHealth()
    {
        healthCollection -= 10;
        TakeDamageEvent.Invoke();

        if (healthCollection == 0)
        {
            Died();
        }
    }
    
    public void PharaohSubtractHealth()
    {
        healthCollection -= 25;
        TakeDamageEvent.Invoke();

        if (healthCollection == 0)
        {
            Died();
        }
    }

    public void SahSubtractHealth()
    {
        healthCollection -= 30;
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
