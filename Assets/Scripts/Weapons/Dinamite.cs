using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dinamite : MonoBehaviour
{
    [SerializeField] private int _damage;
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.TryGetComponent(out Enemy enemy))
        {
            enemy.TakeDamage(_damage);
            Destroy(gameObject);
        }
    }
}

