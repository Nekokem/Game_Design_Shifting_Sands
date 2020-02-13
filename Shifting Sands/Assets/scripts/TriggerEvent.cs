using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerEvent : MonoBehaviour
{
    public UnityEvent TriggerEnterEvent, TriggerExitEvent;

    public void OnTriggerEnter(Collider other)
    {
        TriggerEnterEvent.Invoke();
    }

    public void OnTriggerExit(Collider other)
    {
        TriggerExitEvent.Invoke();
    }
}
