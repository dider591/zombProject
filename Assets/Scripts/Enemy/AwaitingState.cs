using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class AwaitingState : State
{
    private Animator _animator;
    private int Idle = Animator.StringToHash("Idle");

    private void Start()
    {
        _animator = GetComponent<Animator>();
        _animator.Play(Idle);
    }
}
