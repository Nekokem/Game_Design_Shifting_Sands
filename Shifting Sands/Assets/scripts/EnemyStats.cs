using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : CharacterStats
{
    public Color friendColor = Color.green;
    //public ClickParticles enemyParticles;
    
    public override void Die()
    {
        base.Die();
        
        gameObject.GetComponent<Renderer>().material.color = friendColor;
        
        Destroy(gameObject);
        // enemyParticles.ghostPlasm.emissionRate = 0f;

    }

    /*public void Update()
    {
         if (Input.GetMouseButtonDown(0))
         {
             TakeDamage(5);
         }
    }*/
}
