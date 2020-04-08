using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
  public Inentory inventory;
  public pickUpType thisPickUp;
  public enum pickUpType
  {
    GEM,
    Health,
    MAGIC
  }

  public void OnTriggerEnter(Collider other)
  {
    if (thisPickUp == pickUpType.GEM)
    {
      inventory.AddGem();
    }
    
    Destroy(gameObject);
  }
}
