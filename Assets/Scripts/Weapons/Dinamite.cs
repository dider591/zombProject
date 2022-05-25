using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Dinamite : Weapon
{
    [SerializeField] private GameObject _effect;

    private void OnTriggerEnter(Collider trigger)
    {
        if (trigger.TryGetComponent<Enemy>(out Enemy enemy))
        {
            Instantiate(_effect, transform.position, transform.rotation);
            enemy.TakeDamage(Damage);
            Destroy(gameObject);
        }
    }   
}

