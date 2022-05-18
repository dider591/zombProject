using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class Movement : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    [SerializeField] private Animator _playerAnimator;


    private Vector2 _direction;
    private Vector3 _targetVector;
    private InputPlayer _input;

    private void Start()
    {
        _input = new InputPlayer();
        _input.Player.Enable();
    }

    private void Update()
    {
        _direction = _input.Player.Move.ReadValue<Vector2>();
        _targetVector = new Vector3(_direction.x, 0, _direction.y);

        Move(_targetVector);
    }

    private void Move(Vector3 targetVector)
    {
        float scaleMovespeed = _moveSpeed * Time.deltaTime;
        Vector3 move = Quaternion.Euler(0, transform.eulerAngles.y, 0) * targetVector;
        transform.position += move * scaleMovespeed;

        if (targetVector.x != 0 || targetVector.z != 0) 
            _playerAnimator.SetBool("Run", true);
            
        else
            _playerAnimator.SetBool("Run", false);         
    }
}
