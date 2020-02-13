using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.PlayerLoop;

public class UseMagic : MonoBehaviour
{
    public ParticleSystem Spell;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            Spell.Emit(25);
        }
    }
}