using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Look : MonoBehaviour
{
    [SerializeField] private float _speedRotation;

    private InputPlayer _input;
    private Vector2 _direction;
    private Vector3 _targetVector;

    private void Start()
    {
        _input = new InputPlayer();
        _input.Player.Enable();
    }

    private void Update()
    {
        _direction = _input.Player.Move.ReadValue<Vector2>();
        _targetVector = new Vector3(_direction.x, 0, _direction.y);

        Rotation(_targetVector);
    }

    private void Rotation(Vector3 targetVector)
    {
        if (targetVector.magnitude == 0) 
            return;

        var rotation = Quaternion.LookRotation(targetVector);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, rotation, _speedRotation);
    }
}
