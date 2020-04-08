using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnemyHealth : MonoBehaviour
{
    public float healthCollection = 5f;
    public UnityEvent TakeDamageEvent;
    public UnityEvent DieEvent;

    public void MinusHealth(float playAttackDamage)
    {
        healthCollection -= 10;
        TakeDamageEvent.Invoke();

        if (healthCollection <= 0)
        {
            Died();
        }
    }
    
    public void Died()
    {
        DieEvent.Invoke();
    }
}
