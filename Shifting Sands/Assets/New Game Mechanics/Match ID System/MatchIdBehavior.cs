using System;
using System.Collections.Generic;
using UnityEngine;

public class MatchIDBehavior : IDBehavior
{
    public WorkSystemManager workSystemManagerObj;
    private NameID otherIdObj;
    
    private void OnTriggerEnter(Collider other)
    {
        otherIdObj = other.GetComponent<IDBehavior>().nameIDObj;
        CheckId();
    }

    private void CheckId()
    {
        foreach (var obj in workSystemManagerObj.workIDList)
        {
            
            if (otherIdObj == obj.nameIDObj)
            {
                obj.workSystemObj.Work();
            }
        }
    }

}