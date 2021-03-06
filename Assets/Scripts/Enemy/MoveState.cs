using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
[RequireComponent(typeof(Animator))]
public class MoveState : State
{
    [SerializeField] private NavMeshAgent _agent;

    private int Walk = Animator.StringToHash("Walk");

    private Animator _animator;

    private void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        _animator.Play(Walk);
        _agent.SetDestination(Target.transform.position);
    }
}
