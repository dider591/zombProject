using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(InputPlayer))]
public class Thrower : MonoBehaviour
{
    [SerializeField] private Dinamite _dinamite;
    [SerializeField] private Player _player;

    private InputPlayer _input;

    private void Awake()
    {
        _input = new InputPlayer();
        _input.Enable();
        _input.Player.Throw.performed += ctx => ThrowDinamite();
    }

    private void ThrowDinamite()
    {
        if (_player.Dinamite > 0)
        {
            Instantiate(_dinamite, transform.position, _dinamite.transform.rotation);
            _player.DinamiteChanged();
        }       
    }
}
