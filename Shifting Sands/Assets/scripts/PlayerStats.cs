using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : CharacterStats
{
    public EnemyStats enemyStat;
    public Color deadColor = Color.black;


    public override void Die()
    {
        base.Die();
        //kill the player somehow
        gameObject.GetComponent<Renderer>().material.color = deadColor;
        PlayerManager.instance.KillPlayer();
    }

  
}