﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MatchIdBehavior : IDBehavior
{
  
    [Serializable]
    public struct possibleMatch
    {
        public NameID nameIdObj;
        public UnityEvent workEvent, delayedEvent;
    }

    public float holdTime = 0.1f;
    public WaitForSeconds waitObj;
    public List<possibleMatch> triggerEnterMatches, triggerExitMatches;
    private NameID otherIdObj;

    private void Awake()
    {
        waitObj = new WaitForSeconds(holdTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        otherIdObj = other.GetComponent<IDBehavior>().nameIdObj;
        StartCoroutine(CheckId(otherIdObj, triggerEnterMatches));
        //CheckId(otherIdObj, triggerEnterMatches);
    }
   
    private void OnTriggerExit(Collider other)
    {
        otherIdObj = other.GetComponent<IDBehavior>().nameIdObj;
        StartCoroutine(CheckId(otherIdObj, triggerExitMatches));
        //CheckId(otherIdObj, );
    }

    private IEnumerator CheckId(NameID nameId, List<possibleMatch> possibleMatches)
    {
      
        if (nameId == null) yield break;
      
        otherIdObj = nameId;
        foreach (var obj in possibleMatches)
        {
            if (otherIdObj == obj.nameIdObj)
            {
                obj.workEvent.Invoke();
                yield return waitObj;
                obj.delayedEvent.Invoke();
            }
        }
    }
}