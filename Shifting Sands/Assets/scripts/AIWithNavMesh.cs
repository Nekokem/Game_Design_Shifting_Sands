﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class AIWithNavMesh : MonoBehaviour
{
    private NavMeshAgent agent;
    public Transform player;
    public Transform destination;
    
    void Start()
    {
        destination = transform;
        agent = GetComponent<NavMeshAgent>();
    }

    private void OnTriggerEnter(Collider other)
    {
        destination = player;
    }

    private void OnTriggerExit(Collider other)
    {
        destination = transform;
    }

    void Update()
    {
        agent.destination = destination.position;
    }

    public float speed { get; set; }
}
