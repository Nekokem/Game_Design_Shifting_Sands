using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class WorkSystemManager : ScriptableObject
{
   [Serializable]
   public struct possibleMatches
   {
      public NameID nameIDObj;
      public WorkSystem workSystemObj;
   }

   public List<possibleMatches> workIDList;
}
