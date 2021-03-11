using System;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    public Transform goal;
    public NavMeshAgent agent;
    void Update()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.destination = goal.position;
    }
}