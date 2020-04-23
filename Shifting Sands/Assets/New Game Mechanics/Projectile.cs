using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;

public class Projectile : MonoBehaviour
{

    public float spellSpeed;
    public float destoryTime;
    public int playerAttackDamage;
    void Start()
    {
        Destroy(gameObject, destoryTime);
    }

    void Update()
    {
        transform.position += transform.forward * spellSpeed * Time.deltaTime;
    }

    public void OnTriggerEnter(Collider other)
    {
       
        if (other.GetComponent<EnemyHealth>())
        {
            other.GetComponent<EnemyHealth>().MinusHealth(playerAttackDamage);
            Destroy(gameObject);
        }
        
    }
    
}
