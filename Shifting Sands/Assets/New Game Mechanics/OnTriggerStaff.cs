using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnTriggerStaff : MonoBehaviour
{
    public FloatData SwordDamage;
    private void Awake()
    {
        GetComponent<Collider>().isTrigger = true;
    }

    public UnityEvent Enable;
    public UnityEvent Trigger;

    void OnEnable()
    {
        //Enable.Invoke();
        //Debug.Log("Enable");
    }

    private void OnTriggerEnter(Collider other)
    {
        var EnemyHealth = other.GetComponent<EnemyHealth>();
        if (EnemyHealth == null)
        {
            //Debug.Log("no health module on other");
            //abandon all hope
        }
        else
        {
            //Trigger.Invoke();
            EnemyHealth.MinusHealth(SwordDamage.value);
            //Debug.Log("trigger entered SWORRRDD");
        }

    }
}
