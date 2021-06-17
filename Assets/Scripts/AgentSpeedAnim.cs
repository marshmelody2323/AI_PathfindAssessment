using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentSpeedAnim : MonoBehaviour
{
    [SerializeField] private NavMeshAgent agent;

    float velocity;

    private Animator anim;

    private void Start()
    {
        anim = gameObject.GetComponentInChildren<Animator>();
    }

    private void Update()
    {
        AgentSpeed();
    }

    void AgentSpeed()
    {
        velocity = agent.velocity.magnitude / agent.speed;

        if (agent.velocity.magnitude < 1)
        {
            anim.Play("Idle");
        }

        if (agent.velocity.magnitude > 1)
        {
            anim.Play("Walk");
        }
    }
}
