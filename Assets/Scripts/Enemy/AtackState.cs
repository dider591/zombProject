using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class AtackState : State
{
    [SerializeField] private int _damage;
    [SerializeField] private float _delay;
    [SerializeField] private float _transitionRange;

    private float _lastAttackTime;
    private Animator _animator;
    private int AttackAnimation = Animator.StringToHash("Attack");

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (_lastAttackTime <= 0)
        {
            Attack(Target);
            _lastAttackTime = _delay;
        }

        _lastAttackTime -= Time.deltaTime;
    }

    private void Attack(Player target)
    {
        _animator.Play(AttackAnimation);

        if (Vector3.Distance(transform.position, Target.transform.position) < _transitionRange)
        {
            target.ApplyDamage(_damage);
        }
        
    }

    private void StopAttack()
    {
        _animator.StopPlayback();
    }
}
