﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarManager : MonoBehaviour
{
    public Slider slider;


    public void SetMaxHealth(float health)
    {
        //Debug.Log(health);
        slider.maxValue = health;
        slider.minValue = 0.0f;
    }

    public void SetHealth(float health)
    {
        slider.value = health;
        //Debug.Log(health);
    }
}