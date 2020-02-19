using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterStats))]
public class CharacterCombat : MonoBehaviour
{
    public float attackSpeed = 1f;
    private float attackCoolDown = 0f; //slows down the attacks to once per frame so the enemy doesn't die too quickly
    public float attackDelay = 0f;
    
    private CharacterStats myStats;

    public event System.Action OnAttack;
    void Start()
    {
        myStats = GetComponent<CharacterStats>();
    }

    private void Update()
    {
        attackCoolDown -= Time.deltaTime;
    }

    public void Attack(CharacterStats targetStats)
    {
        if (attackCoolDown <= 0f)
        {
            StartCoroutine(DoDamage(targetStats, attackDelay ));
            if (OnAttack != null)
                OnAttack();
            
            attackCoolDown = 1f / attackSpeed;
        }
       
    }

    IEnumerator DoDamage(CharacterStats stats, float delay)
    {
        yield return new WaitForSeconds(delay);
        stats.TakeDamage(myStats.damage.GetValue());
        
    }
}