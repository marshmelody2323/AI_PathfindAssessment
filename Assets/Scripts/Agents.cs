using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class Agents : MonoBehaviour
{
    private NavMeshAgent agent;
    private Waypoint[] waypoints;

    private Waypoint RandomPoint => waypoints[Random.Range(0, waypoints.Length)];

    void Start()
    {
        agent = gameObject.GetComponent<NavMeshAgent>();
        waypoints = FindObjectsOfType<Waypoint>();
    }

    void Update()
    {
        if (!agent.pathPending && agent.remainingDistance < 0.1f)
        {
            agent.SetDestination(RandomPoint.Position);
        }
    }
}