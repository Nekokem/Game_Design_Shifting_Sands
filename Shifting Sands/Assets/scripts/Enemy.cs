using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//handles interaction with the Enemy

[RequireComponent(typeof(EnemyStats))]
[RequireComponent(typeof(EnemyController))]
[RequireComponent(typeof(CharacterCombat))]

public class Enemy : Interactable
{
    private PlayerManager playerManager;
    private CharacterStats myStats; //referencing the stats of the enemy
    
    public Color restingColor;
    
    private void Start()
    {
        playerManager = PlayerManager.instance;
        myStats = GetComponent<CharacterStats>();
    }

    public override void Interact()
    {
        base.Interact();
        CharacterCombat playerCombat = playerManager.player.GetComponent<CharacterCombat>();

        if (playerCombat != null)
        {
            playerCombat.Attack(myStats);
            Debug.Log("you are attacking the enemy");
            
        }
        
    }
    private void FixedUpdate()
    {
        gameObject.GetComponent<Renderer>().material.color = restingColor;
    }

    
}