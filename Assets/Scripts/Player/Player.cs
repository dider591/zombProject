using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{

    [SerializeField]private int _health;
    public int Maney { get; private set; }

    private int _currentHealth;
    private int _revard = 0;

    private void Start()
    {
        _currentHealth = _health;
    }

    private void Update()
    {

    }

    public void ApplyDamage(int damage)
    {
        _currentHealth += damage;

        if (_currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnEnemyDied(int revard)
    {
        _revard += revard;
        Debug.Log(_revard);
    }


}
