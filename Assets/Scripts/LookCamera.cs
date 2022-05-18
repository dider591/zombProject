using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookCamera : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private Vector3 _targetOffset;
    [SerializeField] private float _movementSpeed;

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        transform.position = Vector3.Lerp(transform.position, _target.position - _targetOffset, _movementSpeed * Time.deltaTime);
    }

}
