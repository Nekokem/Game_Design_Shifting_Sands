using System;
using System.Collections.Generic;
using UnityEngine;

public class MatchIDBehavior : BehaviorID
{
    public WorkSystemManager workSystemManagerObj;
    private NameId otherIdObj;
    
    private void OnTriggerEnter(Collider other)
    {
        otherIdObj = other.GetComponent<BehaviorID>().nameIDObj;
        CheckId();
    }

    private void CheckId()
    {
        foreach (var obj in workSystemManagerObj.workIdList)
        {
            
            if (otherIdObj == obj.nameIdObj)
            {
                obj.workSystemObj.Work();
            }
        }
    }

}