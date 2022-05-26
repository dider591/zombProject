using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class CeleborationState : State
{
    private Animator _animator;
    private int Celeboration = Animator.StringToHash("Celeboration");

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    private void OnEnable()
    {
        _animator.Play(Celeboration);
    }

    private void OnDisable()
    {
        _animator.StopPlayback();
    }
}
